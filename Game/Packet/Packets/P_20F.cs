﻿using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Emulator
{
	/// <summary>
	/// Criar personagem - size 36
	/// </summary>
	[StructLayout ( LayoutKind.Sequential , CharSet = CharSet.Ansi , Pack = 1 )]
	public struct P_20F {
		// Atributos
		public SHeader Header;      // 0 a 11		= 12

		public int Slot;            // 12 a 15	= 4

		[MarshalAs ( UnmanagedType.ByValArray , SizeConst = 12 )]
		public byte [ ] NameBytes;  // 16 a 27	= 12

		[MarshalAs ( UnmanagedType.ByValArray , SizeConst = 4 )]
		public byte [ ] Unk1;       // 28 a 31	= 4

		public int ClassInfo;       // 32 a 35	= 4

		// Ajudantes
		public string Name => Functions.GetString ( this.NameBytes );

		// Controlador
		public static void Controller ( Client client , P_20F rcv ) {
			if ( !Regex.IsMatch ( rcv.Name , @"^[A-Za-z0-9-]{4,12}$" ) ) {
				client.Send ( P_101.New ( "Somente letras e números no nome. 4 a 12 caracteres.") );
			}
			else if ( rcv.Slot < 0 || rcv.Slot > 3 ) {
				client.Close ( );
			}
			else if ( rcv.ClassInfo < 0 || rcv.ClassInfo > 3 ) {
				client.Close ( );
			}
			else {
				// Retorna character da conta
				ref Character character = ref client.Account.Characters[rcv.Slot];

				// Verifica se não está vaziu
				if ( character != null ) {
					client.Close ( );
				}
				else {
					character = new Character(SMob.New());
					character.Mob.Name = rcv.Name;
					character.Mob.ClassInfo = (ClassInfo)rcv.ClassInfo;
					character = UserMobDAO.CreateOrUpdateChar(character);
					
					if (character != null)
					{
						//Atualiza o xml da account para salvar o novo char criado
						UserAccountDAO.CreateOrUpdateAccount(client.Account);

						// Envia os pacotes de criação de personagem
						client.Send(P_110.New(client));
						client.Send(P_101.New($"Personagem [{character.Mob.Name}] criado! Bom jogo!"));
					}
					else
						client.Send(P_101.New($"Erro ao criar o personagem, contate o suporte!"));

				}
			}
		}
	}
}
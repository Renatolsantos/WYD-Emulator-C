﻿namespace Emulator
{
    // Tipos de visão
    public enum EnterVision : byte
    {
        Normal = 1,
        LogIn = 2,
        Teleport = 3,
        Summon = 4,

        Flexao = 16,
        Sentado = 32
    }

    public enum LeaveVision : int
    {
        Normal = 0,
        Morrer = 1,
        LogOut = 2,
        Teleport = 3
    }

    public enum ClassInfo : byte
    {
        TK = 0,
        FM = 1,
        BM = 2,
        HT = 3
    }

    public enum ShopType : int
    {
        Normal = 1,
        Skill = 3
    }

    public enum NpcMerchant : byte
    {
        Skill = 19

    }

    public enum TypeSlot : short
    {
        Equip = 0,
        Inventory = 1,
        Storage = 2
    }

    public enum ItemListEf : short
    {
        EF_LEVEL = 1,
        EF_DAMAGE = 2,
        EF_AC = 3,
        EF_HP = 4,
        EF_MP = 5,
        EF_EXP = 6,
        EF_STR = 7,
        EF_INT = 8,
        EF_DEX = 9,
        EF_CON = 10,
        EF_SPECIAL1 = 11,
        EF_SPECIAL2 = 12,
        EF_SPECIAL3 = 13,
        EF_SPECIAL4 = 14,
        EF_SCORE14 = 15,
        EF_SCORE15 = 16,
        EF_POS = 17,
        EF_CLASS = 18,
        EF_R1SIDC = 19,
        EF_R2SIDC = 20,

        ////////////////   BONUS  ////////////////////////////////
        EF_WTYPE = 21,

        EF_REQ_STR = 22,
        EF_REQ_INT = 23,
        EF_REQ_DEX = 24,
        EF_REQ_CON = 25,
        EF_ATTSPEED = 26,
        EF_RANGE = 27,
        EF_PRICE = 28,   // °¡°Ý
        EF_RUNSPEED = 29,
        EF_SPELL = 30,
        EF_DURATION = 31,
        EF_PARM2 = 32,
        EF_GRID = 33,
        EF_GROUND = 34,
        EF_CLAN = 35,
        EF_HWORDCOIN = 36,
        EF_LWORDCOIN = 37,
        EF_VOLATILE = 38,
        EF_BAUEXPERIENCIA = 39,
        EF_PARRY = 40,
        EF_HITRATE = 41,
        EF_CRITICAL = 42,
        EF_SANC = 43,
        EF_SAVEMANA = 44,
        EF_HPADD = 45,
        EF_MPADD = 46,
        EF_REGENHP = 47,
        EF_REGENMP = 48,
        EF_RESIST1 = 49,
        EF_RESIST2 = 50,
        EF_RESIST3 = 51,
        EF_RESIST4 = 52,
        EF_ACADD = 53,
        EF_RESISTALL = 54,
        EF_BONUS = 55,
        EF_HWORDGUILD = 56,  // Ataque PvP
        EF_LWORDGUILD = 57,  // Defesa PvP
        EF_QUEST = 58,
        EF_UNIQUE = 59,
        EF_MAGIC = 60,
        EF_AMOUNT = 61,
        EF_HWORDINDEX = 62,
        EF_LWORDINDEX = 63,
        EF_INIT1 = 64,
        EF_INIT2 = 65,
        EF_INIT3 = 66,
        EF_DAMAGEADD = 67,
        EF_MAGICADD = 68,
        EF_HPADD2 = 69,
        EF_MPADD2 = 70,
        EF_CRITICAL2 = 71,
        EF_ACADD2 = 72,
        EF_DAMAGE2 = 73,
        EF_SPECIALALL = 74,
        EF_CURKILL = 75,  // not used
        EF_LTOTKILL = 76, // not used
        EF_HTOTKILL = 77,  // not used
        EF_INCUBATE = 78,
        EF_MOUNTLIFE = 79,
        EF_MOUNTHP = 80,
        EF_MOUNTSANC = 81,
        EF_MOUNTFEED = 82,
        EF_MOUNTKILL = 83,
        EF_INCUDELAY = 84,
        EF_SUBGUILD = 85,
        EF_ITEMLEVEL = 87,
        EF_DONATE = 91,
        EF_GRADE0 = 100, // A : 0, B: 1, C: 2, D: 3, E: 4, E: 5 Arch
        EF_WDAY = 106,
        EF_HOUR = 107,
        EF_MIN = 108,
        EF_YEAR = 109,
        EF_WMONTH = 110,
        EF_MOBTYPE = 112,
        EF_ITEMTYPE = 113,
        EF_NOSANC = 126,
        EF_NOTRADE = 127,
    }

    public enum Emotion : short
    {
        LevelUP = 14,
        unknow = 15,
        unknow2 = 23,
        unknow3 = 20,
        FogoArtificio = 100
    }

    public enum Time : int
    {
        Hora = 450,
        Dia = 10800
    }

    public enum City : short
    {
        Armia = 0,
        Noutoun = 1,
        Arzan = 2,
        Erion = 3,
        Gelo = 4
    }

    public enum Affect : byte
    {
        Velocidade = 2,
        Pocao = 4,
        Dano = 9,
        EscudoMagico=11,
        ToqueAthena = 15,
        Transformacao = 16,
        ProtecaoElemental = 25,
        FrangoAssado = 30,
        Divina = 34,
        Vigor = 35
    }

    public enum Gate : byte
    {
        Nothing = 0,
        Open = 1,
        Closed = 2,
        Locked = 3
    }
}
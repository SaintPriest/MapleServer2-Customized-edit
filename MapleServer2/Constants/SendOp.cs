﻿namespace MapleServer2.Constants
{
    public enum SendOp : ushort
    {
        NULL = 0x0000,
        REQUEST_VERSION = 0x0001,
        VERSION_RESULT = 0x0002,
        REQUEST_KEY = 0x0004,
        PING = 0x0006,
        REQUEST_LOGIN = 0x0009,
        LOGIN_RESULT = 0x000A,
        SERVER_LIST = 0x000B,
        CHARACTER_LIST = 0x000C,
        MOVE_RESULT = 0x000D,
        LOGIN_TO_GAME = 0x000E,
        GAME_TO_LOGIN = 0x000F,
        GAME_TO_GAME = 0x0010,
        RESPONSE_TIME_SYNC = 0x0011,
        REQUEST_HEARTBEAT = 0x0012,
        REQUEST_CLIENTTICK_SYNC = 0x0013,
        SYNC_NUMBER = 0x0014,
        SERVER_ENTER = 0x0015,
        REQUEST_FIELD_ENTER = 0x0016,
        FIELD_ADD_USER = 0x0017,
        FIELD_REMOVE_USER = 0x0018,
        FIELD_ENTRANCE = 0x0019,
        ROOM_DUNGEON = 0x001A,
        RESULTS = 0x001B,
        USER_SYNC = 0x001C,
        USER_CHAT = 0x001D,
        USER_CHAT_ITEM_LINK = 0x001E,
        EMOTION = 0x001F,
        ITEM_PUT_ON_OR_OFF = 0x0020,
        ITEM_INVENTORY = 0x0021,
        STORAGE_INVENTORY = 0x0022,
        MARKET_INVENTORY = 0x0023,
        FURNISHING_INVENTORY = 0x0024,
        ITEM_PUT_ON = 0x0025,
        ITEM_PUT_OFF = 0x0026,
        ITEM_DROP = 0x0029,
        ITEM_EXTRA_DATA = 0x002A,
        FIELD_ADD_ITEM = 0x002B,
        FIELD_REMOVE_ITEM = 0x002C,
        FIELD_PICKUP_ITEM = 0x002D,
        FIELD_MUTATE_ITEM = 0x002E,
        STAT = 0x002F,
        USER_BATTLE = 0x0030,
        USER_SKIN_COLOR = 0x0031,
        BEAUTY = 0x0032,
        ADVENTURER_BAR = 0x0033,
        REVIVAL_CONFIRM = 0x0034,
        REVIVAL = 0x0035,
        USER_STATE = 0x0037,
        EXP_UP = 0x0038,
        LEVEL_UP = 0x0039,
        MONEY = 0x003A,
        MERET = 0x003B,
        MONEY_TOKEN = 0x003C,
        SKILL_USE = 0x003D,
        SKILL_DAMAGE = 0x003E,
        SKILL_SYNC = 0x003F,
        SKILL_CANCEL = 0x0040,
        SKILL_USE_FAILED = 0x0041,
        SKILL_COOLDOWN = 0x0043,
        SKILL_RESET_COOLDOWN = 0x0044,
        SKILL_POINT = 0x0045,
        STAT_POINT = 0x0046,
        CHARACTER_CREATE = 0x0047,
        BUFF = 0x0048,
        FIELD_PORTAL = 0x0049,
        JOB = 0x004A,
        NPC_MONOLOGUE = 0x004B,
        NPC_TALK = 0x004C,
        REGION_SKILL = 0x004D,
        FUNCTION_CUBE = 0x004E,
        TRIGGER = 0x004F,
        BREAKABLE = 0x0050,
        ROOM = 0x0051,
        SHOP = 0x0052,
        QUEST = 0x0053,
        PARTY = 0x0054,
        MAIL = 0x0055,
        FIELD_ADD_NPC = 0x0056,
        FIELD_REMOVE_NPC = 0x0057,
        FIELD_DEAD_NPC = 0x0058,
        NPC_CONTROL = 0x0059,
        INTERACT_NPC = 0x005A,
        FIELD_ADD_PET = 0x005B,
        FIELD_REMOVE_PET = 0x005C,
        SYNC_PET_TAMING_POINT = 0x005D,
        TOMBSTONE = 0x005E,
        TROPHY = 0x005F,
        USER_MOVE_BY_PORTAL = 0x0060,
        ITEM_TITLE = 0x0061,
        MASSIVE_EVENT = 0x0062,
        BUDDY = 0x0063,
        ADMIN_BLOCK = 0x0064,
        INTERACT_OBJECT = 0x0065,
        STATE_CONSUME_EP = 0x0066,
        STATE_FALL_DAMAGE = 0x0067,
        CINEMATIC = 0x0068,
        ADMIN = 0x0069,
        SET_BUILD_MODE = 0x006A,
        RESPONSE_CUBE = 0x006B,
        CUBES = 0x006C,
        UGC = 0x006D,
        MERET_MARKET = 0x006E,
        CONTENT_SHUTDOWN = 0x006F,
        GUIDE_OBJECT = 0x0070,
        KEY_TABLE = 0x0071,
        FOLLOW_NPC = 0x0072,
        NOTICE = 0x0073,
        RELOCATE_WORLD = 0x0074,
        ITEM_FUSION = 0x0076,
        VIBRATE = 0x0077,
        HIDE_VIBRATE = 0x0078,
        SHOW_VIBRATE = 0x0079,
        CHARACTER_INFO = 0x007A,
        RESPONSE_RIDE = 0x007B,
        RIDE_SYNC = 0x007C,
        FITTING_DOLL = 0x007D,
        BONUS_GAME = 0x007E,
        LOAD_UGC_MAP = 0x007F,
        PROXY_GAME_OBJ = 0x0080,
        GEM = 0x0081,
        TAXI = 0x0082,
        FIND_FIELDS = 0x0083,
        TRADE_EX = 0x0084,
        INVINCIBLE_EFFECT = 0x0085,
        WORLD_MAP = 0x0086,
        MOVE_EVENTFIELD = 0x0087,
        DPS_STAT = 0x0088,
        DEBUG_MODE = 0x0089,
        STORY_BOOK = 0x008A,
        GUIDE_RECORD = 0x008B,
        GUILD = 0x008C,
        GROUP_CHAT = 0x008D,
        RECALL_USER = 0x008E,
        RANK = 0x008F,
        APPEND_MESSAGE_COMMON = 0x0090,
        APPEND_MESSAGE_STRING = 0x0091,
        APPEND_MESSAGE_KILL_BOSS = 0x0092,
        APPEND_CLIENT_LOG = 0x0093,
        APPEND_MESSAGE_ASSIST_BONUS = 0x0094,
        AH = 0x0095,
        UI_TEXT = 0x0096,
        PLAY_NPC_SOUND = 0x0097,
        ITEM_BREAK = 0x0098,
        ITEM_ENCHANT = 0x0099,
        BLACK_MARKET = 0x009A,
        MESO_MARKET = 0x009B,
        TEAM_PVP = 0x009C,
        WEB_OPEN = 0x009D,
        GAMBLE = 0x009E,
        FIELD_MAID = 0x009F,
        USER_MAID = 0x00A0,
        NEWS_NOTIFICATION = 0x00A1,
        SMART_RECOMMEND_BILLING = 0x00A2,
        SYSTEM_SHOP = 0x00A3,
        AUTO_REVIVE = 0x00A4,
        PLAYER_KILL_NOTICE = 0x00A5,
        ATTEND_GIFT = 0x00A6,
        PC_BANG_BONUS = 0x00A7,
        DEAD = 0x00A8,
        DYNAMIC_CHANNEL = 0x00A9,
        USER_ENV = 0x00AA,
        MANUFACTURER = 0x00AB,
        ENTER_UGC_MAP = 0x00AC,
        ITEM_USE = 0x00AE,
        CASH = 0x00AF,
        MY_INFO = 0x00B0,
        SESSION = 0x00B1,
        WORLD_SHARE_INFO = 0x00B2,
        NAME_TAG_SYMBOL = 0x00B3,
        GAME_EVENT = 0x00B4,
        BANNER_LIST = 0x00B5,
        WAITING_TICKET_UPDATE = 0x00B6,
        SET_PCBANG = 0x00B7,
        PVP = 0x00B8,
        HOME_COMMAND = 0x00B9,
        CHAR_MAX_COUNT = 0x00BA,
        FINALIZE_SERVER_ENTER = 0x00BB,
        DROP_ITEM_GET_MESSAGE = 0x00BC,
        MATCH_PARTY = 0x00BD,
        RECALL_SCROLL = 0x00BE,
        USER_CONDITION_EVENT = 0x00BF,
        POTENTIAL_ABILITY = 0x00C0,
        ENCHANT_SCROLL = 0x00C1,
        BOSS_RANKING = 0x00C2,
        GLOBAL_PORTAL = 0x00C3,
        QUIZ_EVENT = 0x00C4,
        PLAY_SYSTEM_SOUND = 0x00C5,
        FISHING = 0x00C6,
        DARK_STREAM = 0x00C7,
        NPS_INFO = 0x00C8,
        PLAY_INSTRUMENT = 0x00C9,
        CHANGE_ATTRIBUTES = 0x00CA,
        CHANGE_ATTRIBUTES_SCROLL = 0x00CB,
        FIELD_PROPERTY = 0x00CC,
        GAME_EVENT_USER_VALUE = 0x00CD,
        RESPONSE_PET = 0x00CE,
        MASTERY = 0x00CF,
        PET_INVENTORY = 0x00D0,
        NOTICE_DIALOG = 0x00D1,
        AA_ERR = 0x00D2,
        SKILL_COMPACT_CONTROL = 0x00D3,
        BANWORD = 0x00D4,
        CHECK_CHAR_NAME_RESULT = 0x00D5,
        PLATFORM_PROTECT_PACKET = 0x00D6,
        PLATFORM_ACCOUNT_SAFE = 0x00D7,
        GLOBAL_FACTOR = 0x00D8,
        SMART_PUSH = 0x00D9,
        PLAY_ARCADE = 0x00DA,
        DEBUG_STATE = 0x00DB,
        CARD_REVERSE_GAME = 0x00DC,
        ITEM_LOCK = 0x00DD,
        HOME_BANK = 0x00DE,
        HOME_DOCTOR = 0x00DF,
        ITEM_SOCKET_SYSTEM = 0x00E0,
        CHARACTER_ABILITY = 0x00E1,
        SHADOW_BUFF = 0x00E2,
        SHADOW_EXPEDITION = 0x00E3,
        ITEM_SOCKET_SCROLL = 0x00E5,
        ITEM_SOCKET_EXPANSION_SCROLL = 0x00E6,
        DICE_GAME = 0x00E7,
        BYPASS_KEY = 0x00E8,
        LOCAL_CAMERA = 0x00EB,
        PREMIUM_CLUB = 0x00ED,
        STEAM_CASH_SHOP = 0x00EF,
        RESET_CAMERA = 0x00F1,
        ONE_TIME_EFFECT = 0x00F3,
        FIREWORKS = 0x00F7,
        CLUB = 0x00F8,
        ITEM_EXCHANGE = 0x0104,
        ITEM = 0x0105,
        ITEM_ENCHANT_TRANSFORM = 0x0106,
        PLAYER_HOST = 0x0107,
        GM_COMMAND = 0x0108,
        ITEM_EXTRACTION = 0x109,
        PET_SKIN = 0x10A,
        DUNGEON_HELPER = 0x010B,
        SKILL_BOOK_TREE = 0x010E,
        BUDDY_EMOTE = 0x10F,
        SUPER_WORLDCHAT = 0x0114,
        MICROGAME = 0x0116,
        SURVIVAL_EVENT = 0x0118,
        LOGIN_REQUIRED = 0x011B,
        SPECTATE = 0x011C,
        ITEM_LAPENSHARD = 0x011D,
        PRESTIGE = 0x011E,
        WORLD_CHAMPION = 0x120,
        SYNC_VALUE = 0x0122,
        NO = 0x0123,
        CHAT_STICKER = 0x0128,
        MARRIAGE = 0x12A,
        LIMIT_BREAK = 0x130,
        UNKNOWN_SYNC = 0x0132
    }
}

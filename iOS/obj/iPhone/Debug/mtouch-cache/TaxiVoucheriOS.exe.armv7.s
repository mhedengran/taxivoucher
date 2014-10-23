.subsections_via_symbols
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,17,1,18,1,64,10,0,0
	.byte 3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0,11,11,62,11,3,8,0
	.byte 0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73,19,56,10,0,0,7,22
	.byte 0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13,0,0,10,57,1,3,8
	.byte 0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13,15,0,73,19,0,0,14
	.byte 16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0,0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 4,1
	.asciz "Mono AOT Compiler 3.10.0 (mono-3.10.0-branch/491d1f5 Fri Oct  3 00:18:38 EDT 2014)"
	.asciz "TaxiVoucheriOS.exe"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,4,5
	.asciz "intptr"
LDIE_U:

	.byte 4,4,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,4,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,4,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,4,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,124,14
	.align 2
Lcie0_end:
.text
	.align 3
methods:
	.space 16
.text
	.align 2
	.no_dead_strip _TaxiVoucher_iOS_Application__ctor
_TaxiVoucher_iOS_Application__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 4
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,8,0,157,229,0,224,157,229,80,224,158,229,0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_0:
.text
	.align 2
	.no_dead_strip _TaxiVoucher_iOS_Application_Main_string__
_TaxiVoucher_iOS_Application_Main_string__:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,28,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 8
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 100,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229,16,0,141,229,0,0,160,227,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 12
	.byte 0,0,159,231,20,0,141,229,0,224,157,229,148,224,158,229,0,0,94,227,0,224,158,21,16,0,157,229,20,32,157,229
	.byte 0,16,160,227
bl _p_1

	.byte 0,224,157,229,180,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,196,224,158,229,0,0,94,227,0,224,158,21
	.byte 28,208,141,226,0,1,189,232,128,128,189,232

Lme_1:
.text
	.align 2
	.no_dead_strip _TaxiVoucher_iOS_AppDelegate__ctor
_TaxiVoucher_iOS_AppDelegate__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 16
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,8,0,157,229
bl _p_2

	.byte 0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_2:
.text
	.align 2
	.no_dead_strip _TaxiVoucher_iOS_AppDelegate_FinishedLaunching_MonoTouch_UIKit_UIApplication_MonoTouch_Foundation_NSDictionary
_TaxiVoucher_iOS_AppDelegate_FinishedLaunching_MonoTouch_UIKit_UIApplication_MonoTouch_Foundation_NSDictionary:

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,76,208,77,226,13,176,160,225,0,160,160,225,36,16,139,229,40,32,139,229
	.byte 0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 20
	.byte 0,0,159,231,8,0,139,229,8,224,155,229,0,224,158,229,12,224,139,229,0,0,160,227,16,0,203,229,8,224,155,229
	.byte 80,224,158,229,0,0,94,227,0,224,158,21,12,224,155,229,0,224,158,229,8,224,155,229,104,224,158,229,0,0,94,227
	.byte 0,224,158,21,8,224,155,229,120,224,158,229,0,0,94,227,0,224,158,21
bl _p_3

	.byte 8,224,155,229,140,224,158,229,0,0,94,227,0,224,158,21,10,0,160,225,8,224,155,229,160,224,158,229,0,0,94,227
	.byte 0,224,158,21
bl _p_4

	.byte 68,0,139,229,8,224,155,229,184,224,158,229,0,0,94,227,0,224,158,21,68,32,155,229,20,16,139,226,2,0,160,225
	.byte 0,32,146,229,15,224,160,225,92,240,146,229,8,224,155,229,224,224,158,229,0,0,94,227,0,224,158,21,0,0,159,229
	.byte 0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 24
	.byte 0,0,159,231
bl _p_5

	.byte 64,0,139,229,20,16,139,226,20,16,155,229,24,32,155,229,28,48,155,229,32,192,155,229,0,192,141,229
bl _p_6

	.byte 64,0,155,229,20,0,138,229,8,224,155,229,44,225,158,229,0,0,94,227,0,224,158,21,10,0,160,225,20,0,154,229
	.byte 56,0,139,229,8,224,155,229,72,225,158,229,0,0,94,227,0,224,158,21
bl _p_7

	.byte 60,0,139,229,8,224,155,229,96,225,158,229,0,0,94,227,0,224,158,21,60,0,155,229
bl _p_8

	.byte 52,0,139,229,8,224,155,229,124,225,158,229,0,0,94,227,0,224,158,21,52,16,155,229,56,32,155,229,2,0,160,225
	.byte 0,32,146,229,15,224,160,225,64,241,146,229,8,224,155,229,164,225,158,229,0,0,94,227,0,224,158,21,10,0,160,225
	.byte 20,0,154,229,48,0,139,229,8,224,155,229,192,225,158,229,0,0,94,227,0,224,158,21,48,16,155,229,1,0,160,225
	.byte 0,16,145,229,15,224,160,225,72,241,145,229,8,224,155,229,228,225,158,229,0,0,94,227,0,224,158,21,1,0,160,227
	.byte 16,0,203,229,8,224,155,229,252,225,158,229,0,0,94,227,0,224,158,21,16,0,219,229,8,224,155,229,16,226,158,229
	.byte 0,0,94,227,0,224,158,21,76,208,139,226,0,13,189,232,128,128,189,232

Lme_3:
.text
	.align 2
	.no_dead_strip _TaxiVoucher_App__ctor
_TaxiVoucher_App__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 28
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,8,0,157,229,0,224,157,229,80,224,158,229,0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_4:
.text
	.align 2
	.no_dead_strip _TaxiVoucher_App_GetMainPage
_TaxiVoucher_App_GetMainPage:

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,28,208,77,226,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 32
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,160,160,227,0,96,160,227,0,224,157,229
	.byte 64,224,158,229,0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227
	.byte 0,224,158,21,0,224,157,229,104,224,158,229,0,0,94,227,0,224,158,21,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 36
	.byte 0,0,159,231
bl _p_5

	.byte 16,0,141,229
bl _p_9

	.byte 16,0,157,229,0,160,160,225,0,224,157,229,156,224,158,229,0,0,94,227,0,224,158,21,10,0,160,225,12,0,141,229
	.byte 0,224,157,229,180,224,158,229,0,0,94,227,0,224,158,21,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 40
	.byte 0,0,159,231
bl _p_5

	.byte 12,16,157,229,8,0,141,229
bl _p_10

	.byte 8,0,157,229,0,96,160,225,0,224,157,229,236,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225
	.byte 0,224,157,229,4,225,158,229,0,0,94,227,0,224,158,21,28,208,141,226,64,5,189,232,128,128,189,232

Lme_5:
.text
	.align 2
	.no_dead_strip _TaxiVoucher_LoginPage__ctor
_TaxiVoucher_LoginPage__ctor:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,48,208,77,226,16,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 44
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 16,0,157,229
bl _p_11

	.byte 0,224,157,229,112,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,128,224,158,229,0,0,94,227,0,224,158,21
	.byte 16,0,157,229,24,0,141,229,0,224,157,229,152,224,158,229,0,0,94,227,0,224,158,21,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 48
	.byte 0,0,159,231
bl _p_5

	.byte 44,0,141,229
bl _p_12

	.byte 44,0,157,229,0,96,160,225,0,224,157,229,204,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,0,0,159,229
	.byte 0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 52
	.byte 0,0,159,231,40,0,141,229,0,224,157,229,244,224,158,229,0,0,94,227,0,224,158,21,40,16,157,229,6,0,160,225
	.byte 0,224,214,229
bl _p_13

	.byte 0,224,157,229,20,225,158,229,0,0,94,227,0,224,158,21,6,0,160,225,36,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 56
	.byte 0,0,159,231,8,16,141,226,0,0,144,229,8,0,141,229,0,224,157,229,72,225,158,229,0,0,94,227,0,224,158,21
	.byte 36,32,157,229,2,0,160,225,8,16,141,226,8,16,157,229,0,224,210,229
bl _p_14

	.byte 0,224,157,229,112,225,158,229,0,0,94,227,0,224,158,21,6,0,160,225,32,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_TaxiVoucheriOS_got - . + 56
	.byte 0,0,159,231,12,16,141,226,0,0,144,229,12,0,141,229,0,224,157,229,164,225,158,229,0,0,94,227,0,224,158,21
	.byte 32,32,157,229,2,0,160,225,12,16,141,226,12,16,157,229,0,224,210,229
bl _p_15

	.byte 6,0,160,225,28,0,141,229,0,224,157,229,212,225,158,229,0,0,94,227,0,224,158,21,24,0,157,229,28,16,157,229
bl _p_16

	.byte 0,224,157,229,240,225,158,229,0,0,94,227,0,224,158,21,0,224,157,229,0,226,158,229,0,0,94,227,0,224,158,21
	.byte 48,208,141,226,64,1,189,232,128,128,189,232

Lme_6:
.text
	.align 3
methods_end:

	.long 0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl _TaxiVoucher_iOS_Application__ctor
bl _TaxiVoucher_iOS_Application_Main_string__
bl _TaxiVoucher_iOS_AppDelegate__ctor
bl _TaxiVoucher_iOS_AppDelegate_FinishedLaunching_MonoTouch_UIKit_UIApplication_MonoTouch_Foundation_NSDictionary
bl _TaxiVoucher_App__ctor
bl _TaxiVoucher_App_GetMainPage
bl _TaxiVoucher_LoginPage__ctor
bl method_addresses
method_addresses_end:
.section __TEXT, __const
	.align 3
code_offsets:

	.long 0

.text
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.section __TEXT, __const
	.align 3
method_info_offsets:

	.long 8,10,1,2
	.short 0
	.byte 1,3,4,3,4,3,5,255,255,255,255,233
.section __TEXT, __const
	.align 3
extra_method_table:

	.long 11,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0
.section __TEXT, __const
	.align 3
extra_method_info_offsets:

	.long 0
.section __TEXT, __const
	.align 3
class_name_table:

	.short 11, 1, 0, 0, 0, 0, 0, 0
	.short 0, 4, 0, 0, 0, 0, 0, 0
	.short 0, 2, 0, 3, 11, 0, 0, 5
	.short 0
.section __TEXT, __const
	.align 3
got_info_offsets:

	.long 18,10,2,2
	.short 0, 10
	.byte 30,2,1,1,1,1,1,3,1,1,47,1,1,3,4,1,5,3
.section __TEXT, __const
	.align 3
ex_info_offsets:

	.long 8,10,1,2
	.short 0
	.byte 128,167,31,68,33,128,189,31,90,255,255,255,253,159
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 18,12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32,18,12,13,0,72,14,8,135,2,68,14,12,136
	.byte 3,142,1,68,14,40,25,12,13,0,72,14,8,135,2,68,14,20,136,5,138,4,139,3,142,1,68,14,96,68,13,11
	.byte 22,12,13,0,72,14,8,135,2,68,14,20,134,5,136,4,138,3,142,1,68,14,48,20,12,13,0,72,14,8,135,2
	.byte 68,14,16,134,4,136,3,142,1,68,14,64
.section __TEXT, __const
	.align 3
class_info_offsets:

	.long 5,10,1,2
	.short 0
	.byte 131,10,7,23,68,23

.text
	.align 4
plt:
_mono_aot_TaxiVoucheriOS_plt:
	.no_dead_strip plt_MonoTouch_UIKit_UIApplication_Main_string___string_string
plt_MonoTouch_UIKit_UIApplication_Main_string___string_string:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 72,71
	.no_dead_strip plt_MonoTouch_UIKit_UIApplicationDelegate__ctor
plt_MonoTouch_UIKit_UIApplicationDelegate__ctor:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 76,76
	.no_dead_strip plt_Xamarin_Forms_Forms_Init
plt_Xamarin_Forms_Forms_Init:
_p_3:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 80,81
	.no_dead_strip plt_MonoTouch_UIKit_UIScreen_get_MainScreen
plt_MonoTouch_UIKit_UIScreen_get_MainScreen:
_p_4:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 84,86
	.no_dead_strip plt__jit_icall_mono_object_new_specific
plt__jit_icall_mono_object_new_specific:
_p_5:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 88,91
	.no_dead_strip plt_MonoTouch_UIKit_UIWindow__ctor_System_Drawing_RectangleF
plt_MonoTouch_UIKit_UIWindow__ctor_System_Drawing_RectangleF:
_p_6:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 92,118
	.no_dead_strip plt_TaxiVoucher_App_GetMainPage
plt_TaxiVoucher_App_GetMainPage:
_p_7:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 96,123
	.no_dead_strip plt_Xamarin_Forms_PageExtensions_CreateViewController_Xamarin_Forms_Page
plt_Xamarin_Forms_PageExtensions_CreateViewController_Xamarin_Forms_Page:
_p_8:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 100,125
	.no_dead_strip plt_TaxiVoucher_LoginPage__ctor
plt_TaxiVoucher_LoginPage__ctor:
_p_9:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 104,130
	.no_dead_strip plt_Xamarin_Forms_NavigationPage__ctor_Xamarin_Forms_Page
plt_Xamarin_Forms_NavigationPage__ctor_Xamarin_Forms_Page:
_p_10:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 108,132
	.no_dead_strip plt_Xamarin_Forms_ContentPage__ctor
plt_Xamarin_Forms_ContentPage__ctor:
_p_11:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 112,137
	.no_dead_strip plt_Xamarin_Forms_Label__ctor
plt_Xamarin_Forms_Label__ctor:
_p_12:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 116,142
	.no_dead_strip plt_Xamarin_Forms_Label_set_Text_string
plt_Xamarin_Forms_Label_set_Text_string:
_p_13:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 120,147
	.no_dead_strip plt_Xamarin_Forms_View_set_VerticalOptions_Xamarin_Forms_LayoutOptions
plt_Xamarin_Forms_View_set_VerticalOptions_Xamarin_Forms_LayoutOptions:
_p_14:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 124,152
	.no_dead_strip plt_Xamarin_Forms_View_set_HorizontalOptions_Xamarin_Forms_LayoutOptions
plt_Xamarin_Forms_View_set_HorizontalOptions_Xamarin_Forms_LayoutOptions:
_p_15:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 128,157
	.no_dead_strip plt_Xamarin_Forms_ContentPage_set_Content_Xamarin_Forms_View
plt_Xamarin_Forms_ContentPage_set_Content_Xamarin_Forms_View:
_p_16:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_TaxiVoucheriOS_got - . + 132,162
plt_end:
.section __TEXT, __const
	.align 3
image_table:

	.long 5
	.asciz "TaxiVoucheriOS"
	.asciz "64207406-6777-4354-B595-8A6BFEE238F5"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
	.asciz "monotouch"
	.asciz "C5FE593A-8E9F-42CC-AC30-E167F87E86A9"
	.asciz ""
	.asciz "84e04ff9cfb79065"
	.align 3

	.long 1,0,0,0,0
	.asciz "Xamarin.Forms.Core"
	.asciz "929C2B5F-212C-4FC4-B7FE-11FC996A9FE6"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
	.asciz "Xamarin.Forms.Platform.iOS"
	.asciz "E51D6868-6B5A-4963-87AA-1A159473F380"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,1,0,5256,2017
	.asciz "mscorlib"
	.asciz "34CB4459-4B5D-47BC-AF5D-887A9696EC39"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
.data
	.align 3
_mono_aot_TaxiVoucheriOS_got:
	.space 140
got_end:
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "64207406-6777-4354-B595-8A6BFEE238F5"
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "TaxiVoucheriOS"
.data
	.align 3
_mono_aot_file_info:

	.long 102,0
	.align 2
	.long _mono_aot_TaxiVoucheriOS_got
	.align 2
	.long methods
	.align 2
	.long 0
	.align 2
	.long blob
	.align 2
	.long class_name_table
	.align 2
	.long class_info_offsets
	.align 2
	.long method_info_offsets
	.align 2
	.long ex_info_offsets
	.align 2
	.long code_offsets
	.align 2
	.long method_addresses
	.align 2
	.long extra_method_info_offsets
	.align 2
	.long extra_method_table
	.align 2
	.long got_info_offsets
	.align 2
	.long methods_end
	.align 2
	.long unwind_info
	.align 2
	.long mem_end
	.align 2
	.long image_table
	.align 2
	.long plt
	.align 2
	.long plt_end
	.align 2
	.long assembly_guid
	.align 2
	.long runtime_version
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long globals
	.align 2
	.long assembly_name
	.align 2
	.long unbox_trampolines
	.align 2
	.long unbox_trampolines_end

	.long 18,140,17,8,14,387000831,0,1027
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,128,4,4,14
	.long 0,0,0,0,0
	.globl _mono_aot_module_TaxiVoucheriOS_info
	.align 2
_mono_aot_module_TaxiVoucheriOS_info:
	.align 2
	.long _mono_aot_file_info
.section __TEXT, __const
	.align 3
blob:

	.byte 0,0,1,4,0,2,5,6,0,1,7,0,2,8,9,0,1,10,0,3,11,12,13,0,5,14,15,16,17,17,12,0
	.byte 39,42,47,40,40,17,0,1,40,40,14,2,128,233,1,40,40,14,1,5,14,2,108,2,40,14,2,128,233,2,17,0
	.byte 25,16,2,118,2,129,198,3,193,0,4,201,3,193,0,7,127,3,195,0,0,132,3,193,0,5,201,7,24,109,111,110
	.byte 111,95,111,98,106,101,99,116,95,110,101,119,95,115,112,101,99,105,102,105,99,0,3,193,0,7,76,3,6,3,195,0
	.byte 0,121,3,7,3,194,0,3,250,3,194,0,9,180,3,194,0,7,122,3,194,0,7,119,3,194,0,3,112,3,194,0
	.byte 3,114,3,194,0,9,179,10,0,2,255,255,255,255,255,52,0,0,193,0,0,0,20,0,0,12,88,0,100,208,0,0
	.byte 13,8,0,1,7,88,10,19,6,255,255,255,255,255,52,0,0,1,24,0,1,2,1,16,0,1,3,7,48,1,1,4
	.byte 5,32,0,0,192,255,255,242,16,0,0,30,128,204,68,128,216,208,0,0,13,8,0,9,0,68,1,24,1,24,1,4
	.byte 5,20,0,24,0,4,5,4,1,32,10,0,2,255,255,255,255,255,52,0,0,193,0,0,0,24,0,0,14,92,72,104
	.byte 208,0,0,13,8,0,2,1,72,6,20,10,38,16,255,255,255,255,255,72,0,0,1,24,0,1,2,1,16,0,1,3
	.byte 5,20,0,1,4,1,20,1,1,5,5,24,1,1,6,5,40,1,1,7,10,76,0,1,8,6,28,1,1,9,5,24
	.byte 1,1,10,5,28,1,1,11,5,40,0,1,12,6,28,1,1,13,5,36,0,1,14,7,24,0,0,192,255,255,189,20
	.byte 0,0,101,130,24,88,130,36,208,0,0,11,36,208,0,0,11,40,10,208,0,0,11,16,0,39,0,88,1,24,0,16
	.byte 5,4,0,16,1,4,0,16,5,8,0,24,0,4,0,4,5,8,0,16,0,16,0,4,0,28,5,8,5,4,0,16
	.byte 1,4,5,8,0,16,5,8,0,20,5,8,0,24,0,4,0,4,5,8,0,16,1,4,5,8,0,20,0,4,0,4
	.byte 5,8,0,20,7,4,2,36,10,0,2,255,255,255,255,255,52,0,0,193,0,0,0,20,0,0,12,88,0,100,208,0
	.byte 0,13,8,0,1,7,88,10,64,7,255,255,255,255,255,56,0,0,1,24,0,1,2,1,16,0,1,3,6,52,0,1
	.byte 4,1,24,1,1,5,11,56,0,0,192,255,255,236,24,0,0,47,129,12,72,129,24,10,6,0,19,0,72,1,24,0
	.byte 16,0,16,0,4,0,4,5,8,1,4,0,16,1,8,0,16,0,16,0,8,0,4,5,8,6,4,0,16,1,4,1
	.byte 20,10,87,14,255,255,255,255,255,56,0,0,1,24,0,1,2,6,24,0,1,3,1,16,0,1,4,1,24,1,1,5
	.byte 6,52,1,1,6,6,40,1,1,7,5,32,1,1,8,6,52,1,1,9,5,40,1,1,10,6,52,1,1,11,6,48
	.byte 1,1,12,5,28,0,0,192,255,255,202,16,0,0,91,130,8,72,130,20,208,0,0,13,16,6,0,39,0,72,1,28
	.byte 5,4,1,16,1,24,0,16,0,16,0,4,0,4,5,8,1,4,0,16,1,4,5,20,0,20,0,4,0,4,0,0
	.byte 5,4,0,16,1,8,5,28,0,20,0,12,0,4,0,0,5,4,0,16,1,8,5,28,0,20,0,12,0,4,0,0
	.byte 5,4,1,8,0,24,5,4,1,32,0,128,144,8,0,0,1,4,128,144,8,0,0,1,196,0,20,23,196,0,20,20
	.byte 196,0,20,19,196,0,20,17,15,128,162,193,0,2,9,24,0,0,4,193,0,2,26,196,0,20,20,193,0,2,9,196
	.byte 0,20,17,193,0,2,21,193,0,2,10,193,0,2,40,193,0,2,39,193,0,2,38,193,0,2,37,193,0,2,36,193
	.byte 0,2,35,193,0,2,28,193,0,2,16,4,4,128,144,8,0,0,1,196,0,20,23,196,0,20,20,196,0,20,19,196
	.byte 0,20,17,30,128,160,129,12,0,0,4,196,0,20,23,196,0,20,20,196,0,20,19,196,0,20,17,194,0,0,3,194
	.byte 0,0,4,194,0,0,28,194,0,0,27,194,0,0,62,194,0,0,50,194,0,0,51,194,0,0,69,194,0,0,70,194
	.byte 0,0,71,194,0,0,58,194,0,0,56,194,0,3,199,194,0,3,182,194,0,3,89,194,0,3,90,194,0,3,98,194
	.byte 0,3,219,194,0,3,94,194,0,3,92,194,0,3,179,194,0,3,180,194,0,3,220,194,0,3,214,194,0,3,213,194
	.byte 0,3,206,98,111,101,104,109,0
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 2
	.long Lglobals_hash

	.long 0,0
.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_0:

	.byte 5
	.asciz "TaxiVoucher_iOS_Application"

	.byte 8,16
LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "TaxiVoucher_iOS_Application"

LDIFF_SYM7=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM9
	.byte 2
	.asciz "TaxiVoucher.iOS.Application:.ctor"
	.long _TaxiVoucher_iOS_Application__ctor
	.long Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM10=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM11=Lfde0_end - Lfde0_start
	.long LDIFF_SYM11
Lfde0_start:

	.long 0
	.align 2
	.long _TaxiVoucher_iOS_Application__ctor

LDIFF_SYM12=Lme_0 - _TaxiVoucher_iOS_Application__ctor
	.long LDIFF_SYM12
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "TaxiVoucher.iOS.Application:Main"
	.long _TaxiVoucher_iOS_Application_Main_string__
	.long Lme_1

	.byte 2,118,16,3
	.asciz "args"

LDIFF_SYM13=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM14=Lfde1_end - Lfde1_start
	.long LDIFF_SYM14
Lfde1_start:

	.long 0
	.align 2
	.long _TaxiVoucher_iOS_Application_Main_string__

LDIFF_SYM15=Lme_1 - _TaxiVoucher_iOS_Application_Main_string__
	.long LDIFF_SYM15
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,40
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_5:

	.byte 8
	.asciz "_Flags"

	.byte 1
LDIFF_SYM16=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 9
	.asciz "Disposed"

	.byte 1,9
	.asciz "NativeRef"

	.byte 2,9
	.asciz "IsDirectBinding"

	.byte 4,9
	.asciz "RegisteredToggleRef"

	.byte 8,9
	.asciz "InFinalizerQueue"

	.byte 16,0,7
	.asciz "_Flags"

LDIFF_SYM17=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM18=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM18
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM19=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_7:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM20=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM20
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM21=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM21
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM22=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM22
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM23=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM23
LTDIE_6:

	.byte 5
	.asciz "System_Boolean"

	.byte 9,16
LDIFF_SYM24=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM24
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM25=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM25
	.byte 2,35,8,0,7
	.asciz "System_Boolean"

LDIFF_SYM26=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM27=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM27
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM28=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM28
LTDIE_4:

	.byte 5
	.asciz "MonoTouch_Foundation_NSObject"

	.byte 20,16
LDIFF_SYM29=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM30=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM30
	.byte 2,35,8,6
	.asciz "class_handle"

LDIFF_SYM31=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 2,35,12,6
	.asciz "flags"

LDIFF_SYM32=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 2,35,16,6
	.asciz "IsDirectBinding"

LDIFF_SYM33=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM33
	.byte 2,35,17,0,7
	.asciz "MonoTouch_Foundation_NSObject"

LDIFF_SYM34=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM35=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM35
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM36=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM36
LTDIE_3:

	.byte 5
	.asciz "MonoTouch_UIKit_UIApplicationDelegate"

	.byte 20,16
LDIFF_SYM37=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM37
	.byte 2,35,0,0,7
	.asciz "MonoTouch_UIKit_UIApplicationDelegate"

LDIFF_SYM38=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM38
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM39=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM39
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM40=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM40
LTDIE_10:

	.byte 5
	.asciz "MonoTouch_UIKit_UIResponder"

	.byte 20,16
LDIFF_SYM41=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM41
	.byte 2,35,0,0,7
	.asciz "MonoTouch_UIKit_UIResponder"

LDIFF_SYM42=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM42
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM43=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM43
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM44=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM44
LTDIE_9:

	.byte 5
	.asciz "MonoTouch_UIKit_UIView"

	.byte 44,16
LDIFF_SYM45=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM45
	.byte 2,35,0,6
	.asciz "__mt_BackgroundColor_var"

LDIFF_SYM46=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,35,20,6
	.asciz "__mt_GestureRecognizers_var"

LDIFF_SYM47=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM47
	.byte 2,35,24,6
	.asciz "__mt_Layer_var"

LDIFF_SYM48=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM48
	.byte 2,35,28,6
	.asciz "__mt_Subviews_var"

LDIFF_SYM49=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM49
	.byte 2,35,32,6
	.asciz "__mt_Superview_var"

LDIFF_SYM50=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM50
	.byte 2,35,36,6
	.asciz "__mt_TintColor_var"

LDIFF_SYM51=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM51
	.byte 2,35,40,0,7
	.asciz "MonoTouch_UIKit_UIView"

LDIFF_SYM52=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM52
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM53=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM53
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM54=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM54
LTDIE_8:

	.byte 5
	.asciz "MonoTouch_UIKit_UIWindow"

	.byte 48,16
LDIFF_SYM55=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM55
	.byte 2,35,0,6
	.asciz "__mt_RootViewController_var"

LDIFF_SYM56=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,35,44,0,7
	.asciz "MonoTouch_UIKit_UIWindow"

LDIFF_SYM57=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM57
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM58=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM58
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM59=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM59
LTDIE_2:

	.byte 5
	.asciz "TaxiVoucher_iOS_AppDelegate"

	.byte 24,16
LDIFF_SYM60=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,0,6
	.asciz "window"

LDIFF_SYM61=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM61
	.byte 2,35,20,0,7
	.asciz "TaxiVoucher_iOS_AppDelegate"

LDIFF_SYM62=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM62
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM63=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM63
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM64=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 2
	.asciz "TaxiVoucher.iOS.AppDelegate:.ctor"
	.long _TaxiVoucher_iOS_AppDelegate__ctor
	.long Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM65=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM65
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM66=Lfde2_end - Lfde2_start
	.long LDIFF_SYM66
Lfde2_start:

	.long 0
	.align 2
	.long _TaxiVoucher_iOS_AppDelegate__ctor

LDIFF_SYM67=Lme_2 - _TaxiVoucher_iOS_AppDelegate__ctor
	.long LDIFF_SYM67
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_11:

	.byte 5
	.asciz "MonoTouch_UIKit_UIApplication"

	.byte 20,16
LDIFF_SYM68=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2,35,0,0,7
	.asciz "MonoTouch_UIKit_UIApplication"

LDIFF_SYM69=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM69
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM70=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM70
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM71=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM71
LTDIE_12:

	.byte 5
	.asciz "MonoTouch_Foundation_NSDictionary"

	.byte 28,16
LDIFF_SYM72=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 2,35,0,6
	.asciz "__mt_Keys_var"

LDIFF_SYM73=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM73
	.byte 2,35,20,6
	.asciz "__mt_Values_var"

LDIFF_SYM74=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM74
	.byte 2,35,24,0,7
	.asciz "MonoTouch_Foundation_NSDictionary"

LDIFF_SYM75=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM75
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM76=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM76
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM77=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 2
	.asciz "TaxiVoucher.iOS.AppDelegate:FinishedLaunching"
	.long _TaxiVoucher_iOS_AppDelegate_FinishedLaunching_MonoTouch_UIKit_UIApplication_MonoTouch_Foundation_NSDictionary
	.long Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM78=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 1,90,3
	.asciz "app"

LDIFF_SYM79=LTDIE_11_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 2,123,36,3
	.asciz "options"

LDIFF_SYM80=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,123,40,11
	.asciz "V_0"

LDIFF_SYM81=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM82=Lfde3_end - Lfde3_start
	.long LDIFF_SYM82
Lfde3_start:

	.long 0
	.align 2
	.long _TaxiVoucher_iOS_AppDelegate_FinishedLaunching_MonoTouch_UIKit_UIApplication_MonoTouch_Foundation_NSDictionary

LDIFF_SYM83=Lme_3 - _TaxiVoucher_iOS_AppDelegate_FinishedLaunching_MonoTouch_UIKit_UIApplication_MonoTouch_Foundation_NSDictionary
	.long LDIFF_SYM83
	.byte 12,13,0,72,14,8,135,2,68,14,20,136,5,138,4,139,3,142,1,68,14,96,68,13,11
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_13:

	.byte 5
	.asciz "TaxiVoucher_App"

	.byte 8,16
LDIFF_SYM84=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,35,0,0,7
	.asciz "TaxiVoucher_App"

LDIFF_SYM85=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM85
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM86=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM86
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM87=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2
	.asciz "TaxiVoucher.App:.ctor"
	.long _TaxiVoucher_App__ctor
	.long Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM88=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM89=Lfde4_end - Lfde4_start
	.long LDIFF_SYM89
Lfde4_start:

	.long 0
	.align 2
	.long _TaxiVoucher_App__ctor

LDIFF_SYM90=Lme_4 - _TaxiVoucher_App__ctor
	.long LDIFF_SYM90
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde4_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_25:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 8,16
LDIFF_SYM91=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM92=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM92
LTDIE_25_POINTER:

	.byte 13
LDIFF_SYM93=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM93
LTDIE_25_REFERENCE:

	.byte 14
LDIFF_SYM94=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM94
LTDIE_24:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 8,16
LDIFF_SYM95=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM96=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM96
LTDIE_24_POINTER:

	.byte 13
LDIFF_SYM97=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM97
LTDIE_24_REFERENCE:

	.byte 14
LDIFF_SYM98=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM98
LTDIE_23:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 8,16
LDIFF_SYM99=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM100=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM100
LTDIE_23_POINTER:

	.byte 13
LDIFF_SYM101=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM101
LTDIE_23_REFERENCE:

	.byte 14
LDIFF_SYM102=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM102
LTDIE_27:

	.byte 5
	.asciz "System_Type"

	.byte 12,16
LDIFF_SYM103=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM104=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM104
	.byte 2,35,8,0,7
	.asciz "System_Type"

LDIFF_SYM105=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM105
LTDIE_27_POINTER:

	.byte 13
LDIFF_SYM106=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM106
LTDIE_27_REFERENCE:

	.byte 14
LDIFF_SYM107=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM107
LTDIE_26:

	.byte 5
	.asciz "System_DelegateData"

	.byte 20,16
LDIFF_SYM108=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM109=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM109
	.byte 2,35,8,6
	.asciz "method_name"

LDIFF_SYM110=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM110
	.byte 2,35,12,6
	.asciz "curried_first_arg"

LDIFF_SYM111=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM111
	.byte 2,35,16,0,7
	.asciz "System_DelegateData"

LDIFF_SYM112=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM112
LTDIE_26_POINTER:

	.byte 13
LDIFF_SYM113=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM113
LTDIE_26_REFERENCE:

	.byte 14
LDIFF_SYM114=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM114
LTDIE_22:

	.byte 5
	.asciz "System_Delegate"

	.byte 44,16
LDIFF_SYM115=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM115
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM116=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 2,35,8,6
	.asciz "invoke_impl"

LDIFF_SYM117=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,35,12,6
	.asciz "m_target"

LDIFF_SYM118=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM118
	.byte 2,35,16,6
	.asciz "method"

LDIFF_SYM119=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM119
	.byte 2,35,20,6
	.asciz "delegate_trampoline"

LDIFF_SYM120=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM120
	.byte 2,35,24,6
	.asciz "method_code"

LDIFF_SYM121=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 2,35,28,6
	.asciz "method_info"

LDIFF_SYM122=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 2,35,32,6
	.asciz "original_method_info"

LDIFF_SYM123=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 2,35,36,6
	.asciz "data"

LDIFF_SYM124=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM124
	.byte 2,35,40,0,7
	.asciz "System_Delegate"

LDIFF_SYM125=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM125
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM126=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM126
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM127=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM127
LTDIE_21:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 52,16
LDIFF_SYM128=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM128
	.byte 2,35,0,6
	.asciz "prev"

LDIFF_SYM129=LTDIE_21_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 2,35,44,6
	.asciz "kpm_next"

LDIFF_SYM130=LTDIE_21_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM130
	.byte 2,35,48,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM131=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM131
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM132=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM132
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM133=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM133
LTDIE_20:

	.byte 5
	.asciz "Xamarin_Forms_PropertyChangingEventHandler"

	.byte 52,16
LDIFF_SYM134=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM134
	.byte 2,35,0,0,7
	.asciz "Xamarin_Forms_PropertyChangingEventHandler"

LDIFF_SYM135=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM135
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM136=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM136
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM137=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM137
LTDIE_28:

	.byte 5
	.asciz "System_ComponentModel_PropertyChangedEventHandler"

	.byte 52,16
LDIFF_SYM138=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM138
	.byte 2,35,0,0,7
	.asciz "System_ComponentModel_PropertyChangedEventHandler"

LDIFF_SYM139=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM139
LTDIE_28_POINTER:

	.byte 13
LDIFF_SYM140=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM140
LTDIE_28_REFERENCE:

	.byte 14
LDIFF_SYM141=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM141
LTDIE_29:

	.byte 5
	.asciz "System_EventHandler"

	.byte 52,16
LDIFF_SYM142=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM142
	.byte 2,35,0,0,7
	.asciz "System_EventHandler"

LDIFF_SYM143=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM143
LTDIE_29_POINTER:

	.byte 13
LDIFF_SYM144=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM144
LTDIE_29_REFERENCE:

	.byte 14
LDIFF_SYM145=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM145
LTDIE_31:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM146=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM146
LTDIE_31_POINTER:

	.byte 13
LDIFF_SYM147=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM147
LTDIE_31_REFERENCE:

	.byte 14
LDIFF_SYM148=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM148
LTDIE_32:

	.byte 5
	.asciz "System_Int32"

	.byte 12,16
LDIFF_SYM149=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM149
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM150=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM150
	.byte 2,35,8,0,7
	.asciz "System_Int32"

LDIFF_SYM151=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM151
LTDIE_32_POINTER:

	.byte 13
LDIFF_SYM152=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM152
LTDIE_32_REFERENCE:

	.byte 14
LDIFF_SYM153=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM153
LTDIE_30:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM154=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM154
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM155=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM155
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM156=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM156
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM157=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM157
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM158=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM158
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM159=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM160=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM161=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM162=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM163=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM164=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM164
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM165=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM165
LTDIE_30_POINTER:

	.byte 13
LDIFF_SYM166=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM166
LTDIE_30_REFERENCE:

	.byte 14
LDIFF_SYM167=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM167
LTDIE_33:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM168=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM168
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM169=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM169
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM170=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM170
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM171=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM171
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM172=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM172
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM173=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM173
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM174=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM174
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM175=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM175
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM176=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM176
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM177=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM177
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM178=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM178
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM179=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM179
LTDIE_33_POINTER:

	.byte 13
LDIFF_SYM180=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM180
LTDIE_33_REFERENCE:

	.byte 14
LDIFF_SYM181=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM181
LTDIE_34:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 20,16
LDIFF_SYM182=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM182
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM183=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 2,35,8,6
	.asciz "_size"

LDIFF_SYM184=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM184
	.byte 2,35,12,6
	.asciz "_version"

LDIFF_SYM185=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM185
	.byte 2,35,16,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM186=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM186
LTDIE_34_POINTER:

	.byte 13
LDIFF_SYM187=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM187
LTDIE_34_REFERENCE:

	.byte 14
LDIFF_SYM188=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM188
LTDIE_35:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM189=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM189
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM190=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM190
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM191=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM191
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM192=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM192
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM193=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM193
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM194=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM194
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM195=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM195
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM196=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM196
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM197=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM197
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM198=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM198
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM199=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM199
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM200=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM200
LTDIE_35_POINTER:

	.byte 13
LDIFF_SYM201=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM201
LTDIE_35_REFERENCE:

	.byte 14
LDIFF_SYM202=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM202
LTDIE_19:

	.byte 5
	.asciz "Xamarin_Forms_BindableObject"

	.byte 44,16
LDIFF_SYM203=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM203
	.byte 2,35,0,6
	.asciz "PropertyChanging"

LDIFF_SYM204=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 2,35,8,6
	.asciz "PropertyChanged"

LDIFF_SYM205=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM205
	.byte 2,35,12,6
	.asciz "BindingContextChanged"

LDIFF_SYM206=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM206
	.byte 2,35,16,6
	.asciz "inheritedContext"

LDIFF_SYM207=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM207
	.byte 2,35,20,6
	.asciz "bindings"

LDIFF_SYM208=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM208
	.byte 2,35,24,6
	.asciz "values"

LDIFF_SYM209=LTDIE_33_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM209
	.byte 2,35,28,6
	.asciz "manuallySetValues"

LDIFF_SYM210=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM210
	.byte 2,35,32,6
	.asciz "delayedSetters"

LDIFF_SYM211=LTDIE_35_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM211
	.byte 2,35,36,6
	.asciz "applying"

LDIFF_SYM212=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM212
	.byte 2,35,40,0,7
	.asciz "Xamarin_Forms_BindableObject"

LDIFF_SYM213=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM213
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM214=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM214
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM215=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM215
LTDIE_36:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM216=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM217=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM217
LTDIE_36_POINTER:

	.byte 13
LDIFF_SYM218=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM218
LTDIE_36_REFERENCE:

	.byte 14
LDIFF_SYM219=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM219
LTDIE_37:

	.byte 17
	.asciz "Xamarin_Forms_IPlatform"

	.byte 8,7
	.asciz "Xamarin_Forms_IPlatform"

LDIFF_SYM220=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM220
LTDIE_37_POINTER:

	.byte 13
LDIFF_SYM221=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM221
LTDIE_37_REFERENCE:

	.byte 14
LDIFF_SYM222=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM222
LTDIE_39:

	.byte 5
	.asciz "System_Func`1"

	.byte 52,16
LDIFF_SYM223=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM224=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM224
LTDIE_39_POINTER:

	.byte 13
LDIFF_SYM225=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM225
LTDIE_39_REFERENCE:

	.byte 14
LDIFF_SYM226=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM226
LTDIE_41:

	.byte 17
	.asciz "System_Collections_IDictionary"

	.byte 8,7
	.asciz "System_Collections_IDictionary"

LDIFF_SYM227=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM227
LTDIE_41_POINTER:

	.byte 13
LDIFF_SYM228=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM228
LTDIE_41_REFERENCE:

	.byte 14
LDIFF_SYM229=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM229
LTDIE_40:

	.byte 5
	.asciz "System_Exception"

	.byte 60,16
LDIFF_SYM230=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 2,35,0,6
	.asciz "trace_ips"

LDIFF_SYM231=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 2,35,8,6
	.asciz "inner_exception"

LDIFF_SYM232=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM232
	.byte 2,35,12,6
	.asciz "message"

LDIFF_SYM233=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM233
	.byte 2,35,16,6
	.asciz "help_link"

LDIFF_SYM234=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM234
	.byte 2,35,20,6
	.asciz "class_name"

LDIFF_SYM235=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM235
	.byte 2,35,24,6
	.asciz "stack_trace"

LDIFF_SYM236=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 2,35,28,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM237=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,35,32,6
	.asciz "remote_stack_index"

LDIFF_SYM238=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 2,35,36,6
	.asciz "hresult"

LDIFF_SYM239=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM239
	.byte 2,35,40,6
	.asciz "source"

LDIFF_SYM240=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM240
	.byte 2,35,44,6
	.asciz "_data"

LDIFF_SYM241=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM241
	.byte 2,35,48,6
	.asciz "captured_traces"

LDIFF_SYM242=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM242
	.byte 2,35,52,6
	.asciz "native_trace_ips"

LDIFF_SYM243=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM243
	.byte 2,35,56,0,7
	.asciz "System_Exception"

LDIFF_SYM244=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM244
LTDIE_40_POINTER:

	.byte 13
LDIFF_SYM245=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM245
LTDIE_40_REFERENCE:

	.byte 14
LDIFF_SYM246=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM246
LTDIE_42:

	.byte 8
	.asciz "System_Threading_LazyThreadSafetyMode"

	.byte 4
LDIFF_SYM247=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM247
	.byte 9
	.asciz "None"

	.byte 0,9
	.asciz "PublicationOnly"

	.byte 1,9
	.asciz "ExecutionAndPublication"

	.byte 2,0,7
	.asciz "System_Threading_LazyThreadSafetyMode"

LDIFF_SYM248=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM248
LTDIE_42_POINTER:

	.byte 13
LDIFF_SYM249=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM249
LTDIE_42_REFERENCE:

	.byte 14
LDIFF_SYM250=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM250
LTDIE_38:

	.byte 5
	.asciz "System_Lazy`1"

	.byte 44,16
LDIFF_SYM251=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM251
	.byte 2,35,0,6
	.asciz "value"

LDIFF_SYM252=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM252
	.byte 2,35,20,6
	.asciz "factory"

LDIFF_SYM253=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM253
	.byte 2,35,8,6
	.asciz "monitor"

LDIFF_SYM254=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM254
	.byte 2,35,12,6
	.asciz "exception"

LDIFF_SYM255=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 2,35,16,6
	.asciz "mode"

LDIFF_SYM256=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 2,35,36,6
	.asciz "inited"

LDIFF_SYM257=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM257
	.byte 2,35,40,0,7
	.asciz "System_Lazy`1"

LDIFF_SYM258=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM258
LTDIE_38_POINTER:

	.byte 13
LDIFF_SYM259=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM259
LTDIE_38_REFERENCE:

	.byte 14
LDIFF_SYM260=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM260
LTDIE_18:

	.byte 5
	.asciz "Xamarin_Forms_Element"

	.byte 84,16
LDIFF_SYM261=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM261
	.byte 2,35,0,6
	.asciz "ChildAdded"

LDIFF_SYM262=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM262
	.byte 2,35,44,6
	.asciz "ChildRemoved"

LDIFF_SYM263=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM263
	.byte 2,35,48,6
	.asciz "DescendantAdded"

LDIFF_SYM264=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 2,35,52,6
	.asciz "DescendantRemoved"

LDIFF_SYM265=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM265
	.byte 2,35,56,6
	.asciz "PlatformSet"

LDIFF_SYM266=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM266
	.byte 2,35,60,6
	.asciz "parent"

LDIFF_SYM267=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM267
	.byte 2,35,64,6
	.asciz "canvas"

LDIFF_SYM268=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM268
	.byte 2,35,68,6
	.asciz "styleId"

LDIFF_SYM269=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM269
	.byte 2,35,72,6
	.asciz "id"

LDIFF_SYM270=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM270
	.byte 2,35,76,6
	.asciz "<Owned>k__BackingField"

LDIFF_SYM271=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 2,35,80,0,7
	.asciz "Xamarin_Forms_Element"

LDIFF_SYM272=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM272
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM273=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM273
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM274=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM274
LTDIE_43:

	.byte 5
	.asciz "System_Double"

	.byte 16,16
LDIFF_SYM275=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM275
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM276=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM276
	.byte 2,35,8,0,7
	.asciz "System_Double"

LDIFF_SYM277=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM277
LTDIE_43_POINTER:

	.byte 13
LDIFF_SYM278=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM278
LTDIE_43_REFERENCE:

	.byte 14
LDIFF_SYM279=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM279
LTDIE_46:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM280=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM280
LTDIE_46_POINTER:

	.byte 13
LDIFF_SYM281=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM281
LTDIE_46_REFERENCE:

	.byte 14
LDIFF_SYM282=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM282
LTDIE_45:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM283=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM283
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM284=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM284
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM285=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM286=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM287=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM288=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM288
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM289=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM289
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM290=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM290
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM291=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM292=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM293=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM293
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM294=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM294
LTDIE_45_POINTER:

	.byte 13
LDIFF_SYM295=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM295
LTDIE_45_REFERENCE:

	.byte 14
LDIFF_SYM296=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM296
LTDIE_44:

	.byte 5
	.asciz "Xamarin_Forms_ResourceDictionary"

	.byte 12,16
LDIFF_SYM297=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM297
	.byte 2,35,0,6
	.asciz "innerDictionary"

LDIFF_SYM298=LTDIE_45_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM298
	.byte 2,35,8,0,7
	.asciz "Xamarin_Forms_ResourceDictionary"

LDIFF_SYM299=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM299
LTDIE_44_POINTER:

	.byte 13
LDIFF_SYM300=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM300
LTDIE_44_REFERENCE:

	.byte 14
LDIFF_SYM301=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM301
LTDIE_47:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM302=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM302
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM303=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM303
LTDIE_47_POINTER:

	.byte 13
LDIFF_SYM304=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM304
LTDIE_47_REFERENCE:

	.byte 14
LDIFF_SYM305=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM305
LTDIE_48:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM306=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM307=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM307
LTDIE_48_POINTER:

	.byte 13
LDIFF_SYM308=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM308
LTDIE_48_REFERENCE:

	.byte 14
LDIFF_SYM309=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM309
LTDIE_49:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM310=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM310
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM311=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM311
LTDIE_49_POINTER:

	.byte 13
LDIFF_SYM312=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM312
LTDIE_49_REFERENCE:

	.byte 14
LDIFF_SYM313=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM313
LTDIE_17:

	.byte 5
	.asciz "Xamarin_Forms_VisualElement"

	.byte 200,1,16
LDIFF_SYM314=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM314
	.byte 2,35,0,6
	.asciz "isNativeStateConsistent"

LDIFF_SYM315=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM315
	.byte 2,35,120,6
	.asciz "mockX"

LDIFF_SYM316=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,35,124,6
	.asciz "mockY"

LDIFF_SYM317=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM317
	.byte 3,35,132,1,6
	.asciz "mockWidth"

LDIFF_SYM318=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM318
	.byte 3,35,140,1,6
	.asciz "mockHeight"

LDIFF_SYM319=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM319
	.byte 3,35,148,1,6
	.asciz "widthRequest"

LDIFF_SYM320=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM320
	.byte 3,35,156,1,6
	.asciz "heightRequest"

LDIFF_SYM321=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 3,35,164,1,6
	.asciz "minimumWidthRequest"

LDIFF_SYM322=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM322
	.byte 3,35,172,1,6
	.asciz "minimumHeightRequest"

LDIFF_SYM323=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM323
	.byte 3,35,180,1,6
	.asciz "resourceDictionary"

LDIFF_SYM324=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM324
	.byte 2,35,84,6
	.asciz "ChildrenReordered"

LDIFF_SYM325=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM325
	.byte 2,35,88,6
	.asciz "BatchCommitted"

LDIFF_SYM326=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM326
	.byte 2,35,92,6
	.asciz "SizeChanged"

LDIFF_SYM327=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM327
	.byte 2,35,96,6
	.asciz "MeasureInvalidated"

LDIFF_SYM328=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM328
	.byte 2,35,100,6
	.asciz "Focused"

LDIFF_SYM329=LTDIE_48_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM329
	.byte 2,35,104,6
	.asciz "Unfocused"

LDIFF_SYM330=LTDIE_48_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM330
	.byte 2,35,108,6
	.asciz "isFocused"

LDIFF_SYM331=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM331
	.byte 3,35,188,1,6
	.asciz "FocusRequested"

LDIFF_SYM332=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM332
	.byte 2,35,112,6
	.asciz "UnfocusRequested"

LDIFF_SYM333=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM333
	.byte 2,35,116,6
	.asciz "batched"

LDIFF_SYM334=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM334
	.byte 3,35,192,1,6
	.asciz "isPlatformEnabled"

LDIFF_SYM335=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM335
	.byte 3,35,196,1,0,7
	.asciz "Xamarin_Forms_VisualElement"

LDIFF_SYM336=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM336
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM337=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM337
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM338=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM338
LTDIE_52:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM339=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM339
LTDIE_52_POINTER:

	.byte 13
LDIFF_SYM340=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM340
LTDIE_52_REFERENCE:

	.byte 14
LDIFF_SYM341=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM341
LTDIE_51:

	.byte 5
	.asciz "System_Collections_ObjectModel_Collection`1"

	.byte 16,16
LDIFF_SYM342=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM342
	.byte 2,35,0,6
	.asciz "items"

LDIFF_SYM343=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM343
	.byte 2,35,8,6
	.asciz "syncRoot"

LDIFF_SYM344=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM344
	.byte 2,35,12,0,7
	.asciz "System_Collections_ObjectModel_Collection`1"

LDIFF_SYM345=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM345
LTDIE_51_POINTER:

	.byte 13
LDIFF_SYM346=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM346
LTDIE_51_REFERENCE:

	.byte 14
LDIFF_SYM347=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM347
LTDIE_53:

	.byte 5
	.asciz "_SimpleMonitor"

	.byte 12,16
LDIFF_SYM348=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM348
	.byte 2,35,0,6
	.asciz "_busyCount"

LDIFF_SYM349=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM349
	.byte 2,35,8,0,7
	.asciz "_SimpleMonitor"

LDIFF_SYM350=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM350
LTDIE_53_POINTER:

	.byte 13
LDIFF_SYM351=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM351
LTDIE_53_REFERENCE:

	.byte 14
LDIFF_SYM352=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM352
LTDIE_54:

	.byte 5
	.asciz "System_Collections_Specialized_NotifyCollectionChangedEventHandler"

	.byte 52,16
LDIFF_SYM353=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM353
	.byte 2,35,0,0,7
	.asciz "System_Collections_Specialized_NotifyCollectionChangedEventHandler"

LDIFF_SYM354=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM354
LTDIE_54_POINTER:

	.byte 13
LDIFF_SYM355=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM355
LTDIE_54_REFERENCE:

	.byte 14
LDIFF_SYM356=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM356
LTDIE_50:

	.byte 5
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

	.byte 28,16
LDIFF_SYM357=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM357
	.byte 2,35,0,6
	.asciz "_monitor"

LDIFF_SYM358=LTDIE_53_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM358
	.byte 2,35,16,6
	.asciz "CollectionChanged"

LDIFF_SYM359=LTDIE_54_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM359
	.byte 2,35,20,6
	.asciz "PropertyChanged"

LDIFF_SYM360=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM360
	.byte 2,35,24,0,7
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

LDIFF_SYM361=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM361
LTDIE_50_POINTER:

	.byte 13
LDIFF_SYM362=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM362
LTDIE_50_REFERENCE:

	.byte 14
LDIFF_SYM363=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM363
LTDIE_55:

	.byte 5
	.asciz "System_Collections_ObjectModel_ReadOnlyCollection`1"

	.byte 12,16
LDIFF_SYM364=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM364
	.byte 2,35,0,6
	.asciz "list"

LDIFF_SYM365=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM365
	.byte 2,35,8,0,7
	.asciz "System_Collections_ObjectModel_ReadOnlyCollection`1"

LDIFF_SYM366=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM366
LTDIE_55_POINTER:

	.byte 13
LDIFF_SYM367=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM367
LTDIE_55_REFERENCE:

	.byte 14
LDIFF_SYM368=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM368
LTDIE_56:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM369=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM369
LTDIE_56_POINTER:

	.byte 13
LDIFF_SYM370=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM370
LTDIE_56_REFERENCE:

	.byte 14
LDIFF_SYM371=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM371
LTDIE_16:

	.byte 5
	.asciz "Xamarin_Forms_Page"

	.byte 136,2,16
LDIFF_SYM372=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM372
	.byte 2,35,0,6
	.asciz "LayoutChanged"

LDIFF_SYM373=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM373
	.byte 3,35,200,1,6
	.asciz "internalChildren"

LDIFF_SYM374=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM374
	.byte 3,35,204,1,6
	.asciz "logicalChildren"

LDIFF_SYM375=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM375
	.byte 3,35,208,1,6
	.asciz "containerAreaSet"

LDIFF_SYM376=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM376
	.byte 3,35,224,1,6
	.asciz "containerArea"

LDIFF_SYM377=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 3,35,228,1,6
	.asciz "Appearing"

LDIFF_SYM378=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM378
	.byte 3,35,212,1,6
	.asciz "Disappearing"

LDIFF_SYM379=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM379
	.byte 3,35,216,1,6
	.asciz "hasAppeared"

LDIFF_SYM380=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM380
	.byte 3,35,132,2,6
	.asciz "allocatedFlag"

LDIFF_SYM381=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM381
	.byte 3,35,133,2,6
	.asciz "<ToolbarItems>k__BackingField"

LDIFF_SYM382=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM382
	.byte 3,35,220,1,0,7
	.asciz "Xamarin_Forms_Page"

LDIFF_SYM383=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM383
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM384=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM384
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM385=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM385
LTDIE_60:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM386=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM386
LTDIE_60_POINTER:

	.byte 13
LDIFF_SYM387=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM387
LTDIE_60_REFERENCE:

	.byte 14
LDIFF_SYM388=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM388
LTDIE_59:

	.byte 5
	.asciz "System_Collections_ObjectModel_Collection`1"

	.byte 16,16
LDIFF_SYM389=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM389
	.byte 2,35,0,6
	.asciz "items"

LDIFF_SYM390=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM390
	.byte 2,35,8,6
	.asciz "syncRoot"

LDIFF_SYM391=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM391
	.byte 2,35,12,0,7
	.asciz "System_Collections_ObjectModel_Collection`1"

LDIFF_SYM392=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM392
LTDIE_59_POINTER:

	.byte 13
LDIFF_SYM393=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM393
LTDIE_59_REFERENCE:

	.byte 14
LDIFF_SYM394=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM394
LTDIE_61:

	.byte 5
	.asciz "_SimpleMonitor"

	.byte 12,16
LDIFF_SYM395=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM395
	.byte 2,35,0,6
	.asciz "_busyCount"

LDIFF_SYM396=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM396
	.byte 2,35,8,0,7
	.asciz "_SimpleMonitor"

LDIFF_SYM397=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM397
LTDIE_61_POINTER:

	.byte 13
LDIFF_SYM398=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM398
LTDIE_61_REFERENCE:

	.byte 14
LDIFF_SYM399=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM399
LTDIE_58:

	.byte 5
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

	.byte 28,16
LDIFF_SYM400=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM400
	.byte 2,35,0,6
	.asciz "_monitor"

LDIFF_SYM401=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM401
	.byte 2,35,16,6
	.asciz "CollectionChanged"

LDIFF_SYM402=LTDIE_54_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM402
	.byte 2,35,20,6
	.asciz "PropertyChanged"

LDIFF_SYM403=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM403
	.byte 2,35,24,0,7
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

LDIFF_SYM404=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM404
LTDIE_58_POINTER:

	.byte 13
LDIFF_SYM405=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM405
LTDIE_58_REFERENCE:

	.byte 14
LDIFF_SYM406=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM406
LTDIE_57:

	.byte 5
	.asciz "Xamarin_Forms_View"

	.byte 204,1,16
LDIFF_SYM407=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM407
	.byte 2,35,0,6
	.asciz "gestureRecognizers"

LDIFF_SYM408=LTDIE_58_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM408
	.byte 3,35,200,1,0,7
	.asciz "Xamarin_Forms_View"

LDIFF_SYM409=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM409
LTDIE_57_POINTER:

	.byte 13
LDIFF_SYM410=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM410
LTDIE_57_REFERENCE:

	.byte 14
LDIFF_SYM411=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM411
LTDIE_15:

	.byte 5
	.asciz "Xamarin_Forms_ContentPage"

	.byte 140,2,16
LDIFF_SYM412=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM412
	.byte 2,35,0,6
	.asciz "content"

LDIFF_SYM413=LTDIE_57_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM413
	.byte 3,35,136,2,0,7
	.asciz "Xamarin_Forms_ContentPage"

LDIFF_SYM414=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM414
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM415=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM415
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM416=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM416
LTDIE_14:

	.byte 5
	.asciz "TaxiVoucher_LoginPage"

	.byte 140,2,16
LDIFF_SYM417=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM417
	.byte 2,35,0,0,7
	.asciz "TaxiVoucher_LoginPage"

LDIFF_SYM418=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM418
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM419=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM419
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM420=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM420
	.byte 2
	.asciz "TaxiVoucher.App:GetMainPage"
	.long _TaxiVoucher_App_GetMainPage
	.long Lme_5

	.byte 2,118,16,11
	.asciz "login"

LDIFF_SYM421=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM421
	.byte 1,90,11
	.asciz "V_1"

LDIFF_SYM422=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM422
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM423=Lfde5_end - Lfde5_start
	.long LDIFF_SYM423
Lfde5_start:

	.long 0
	.align 2
	.long _TaxiVoucher_App_GetMainPage

LDIFF_SYM424=Lme_5 - _TaxiVoucher_App_GetMainPage
	.long LDIFF_SYM424
	.byte 12,13,0,72,14,8,135,2,68,14,20,134,5,136,4,138,3,142,1,68,14,48
	.align 2
Lfde5_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_62:

	.byte 5
	.asciz "Xamarin_Forms_Label"

	.byte 204,1,16
LDIFF_SYM425=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM425
	.byte 2,35,0,0,7
	.asciz "Xamarin_Forms_Label"

LDIFF_SYM426=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM426
LTDIE_62_POINTER:

	.byte 13
LDIFF_SYM427=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM427
LTDIE_62_REFERENCE:

	.byte 14
LDIFF_SYM428=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM428
	.byte 2
	.asciz "TaxiVoucher.LoginPage:.ctor"
	.long _TaxiVoucher_LoginPage__ctor
	.long Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM429=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM429
	.byte 2,125,16,11
	.asciz "V_0"

LDIFF_SYM430=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM430
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM431=Lfde6_end - Lfde6_start
	.long LDIFF_SYM431
Lfde6_start:

	.long 0
	.align 2
	.long _TaxiVoucher_LoginPage__ctor

LDIFF_SYM432=Lme_6 - _TaxiVoucher_LoginPage__ctor
	.long LDIFF_SYM432
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,64
	.align 2
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:

	.long Ldebug_line_end - . -4
	.short 2
	.long Ldebug_line_header_end - . -4
	.byte 1,1,251,14,13,0,1,1,1,1,0,0,0,1,0,0,1
.section __DWARF, __debug_line,regular,debug
	.asciz "/Users/Hedengran/Documents/Xamarin/TaxiVoucher/iOS"
	.asciz "/Users/Hedengran/Documents/Xamarin/TaxiVoucher/TaxiVoucher"
	.asciz "/Users/Hedengran/Documents/Xamarin/TaxiVoucher/TaxiVoucher/Views"

	.byte 0
	.asciz "<unknown>"

	.byte 0,0,0
	.asciz "Main.cs"

	.byte 1,0,0
	.asciz "AppDelegate.cs"

	.byte 1,0,0
	.asciz "App.cs"

	.byte 2,0,0
	.asciz "LoginPage.cs"

	.byte 3,0,0,0
Ldebug_line_header_end:
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _TaxiVoucher_iOS_Application_Main_string__

	.byte 3,13,4,2,1,3,13,2,196,0,1,8,119,3,1,2,208,0,1,2,44,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _TaxiVoucher_iOS_AppDelegate_FinishedLaunching_MonoTouch_UIKit_UIApplication_MonoTouch_Foundation_NSDictionary

	.byte 3,17,4,3,1,3,17,2,216,0,1,8,117,8,62,3,2,2,160,1,1,3,1,2,248,0,1,3,2,2,192,0
	.byte 1,8,117,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _TaxiVoucher_App_GetMainPage

	.byte 3,8,4,4,1,3,8,2,200,0,1,8,117,3,1,2,52,1,3,1,2,208,0,1,2,52,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _TaxiVoucher_LoginPage__ctor

	.byte 3,7,4,5,1,3,7,2,200,0,1,8,229,243,3,1,2,204,0,1,3,1,2,200,0,1,3,1,2,220,0,1
	.byte 3,125,2,228,0,1,8,177,2,44,1,0,1,1,0,1,1
Ldebug_line_end:
.text
	.align 3
mem_end:

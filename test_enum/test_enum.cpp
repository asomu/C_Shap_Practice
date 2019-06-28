// test_enum.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>


typedef enum
{
	DEFAULT_RFDEVICE,
	TEST_DEVICE,

	/* WTR Devices */
	WTR1605,
	WTR1625,
	WTR2605,
	WTR2955,
	WTR2955_WXE,
	WTR2955V110,
	WTR2955V110_WXE,
	WTR2965,
	WTR2965_WXE,
	WTR3925,
	WTR3925_WXE,
	WTR3950,
	WTR3950_WXE,
	WTR4905,
	WTR4905_WXE,
	WTR4905V100,
	WTR4905V100_WXE,
	WTR5975,
	WTL5000,

	/* SDR Devices */
	SDR660,
	SDR845,
	SDR855,
	SDR051,         /* MMW RF Device */
	SDR051V2,
	SDR052,         /* MMW IF Device */
	SDR052V2,
	SDR8154,
	SDR8150,

	/* Last WTR/SDR enum */
	RFDEVICE_MAX_TRANSCEIVER,

	/* Gen Devices (3rd party) */
	GEN_ASM,
	GEN_ASM_PRX,
	GEN_ASM_PRX_1,
	GEN_ASM_PRX_2,
	GEN_ASM_DRX,
	GEN_ASM_DRX_1,
	GEN_ASM_DRX_2,
	GEN_ASM_DRX_3,
	GEN_ASM_DRX_4,
	GEN_ASM_TX,
	GEN_ASM_1,
	GEN_ASM_2,
	GEN_ASM_3,
	GEN_ASM_GRFC_TUNER,
	GEN_ASM_GPIO,
	GEN_PA,
	GEN_LNA,
	GEN_LNA_1,
	GEN_LNA_2,
	GEN_LNA_3,
	GEN_LNA_4,
	GEN_LNA_5,
	GEN_LNA_6,
	GEN_LNA_7,
	GEN_LNA_8,
	GEN_LNA_9,
	GEN_LNA_10,
	GEN_LNA_11,
	GEN_LNA_PRX,
	GEN_LNA_DRX,
	GEN_COUPLER,
	GEN_XSW,
	GEN_XSW_1,
	GEN_XSW_2,
	GEN_XSW_3,
	GEN_XSW_4,
	GEN_XSW_5,
	GEN_PHYSICAL,
	GEN_DEVICE,

	/* Power Tracker Devices */
	PWR_TRACKER,
	QFE1100,
	QFE1101,
	QFE2101,
	QFE3100,
	QET4100,
	QET4101,
	QET5100,
	QET5102,
	QET6100,
	QET6200,
	PMR051,
	/* QFE Devices */
	QFE1035,        /* BOLT Low band ASM */
	QFE1036,        /* BOLT ASM */
	QFE1040,        /* BOLT Diversity switch matrix */
	QFE1040_LB_W0,  /* BOLT Low band ASM for WTR0*/
	QFE1040_MB_W0,  /* BOLT Mid band ASM for WTR0*/
	QFE1040_HB_W0,  /* BOLT High band ASM for WTR0*/
	QFE1040_LB_W1,  /* BOLT Low band ASM for WTR1*/
	QFE1040_MB_W1,  /* BOLT Mid band ASM for WTR1*/
	QFE1040_HB_W1,  /* BOLT High band ASM for WTR1*/
	QFE1045,        /* BOLT Mid band ASM */
	QFE1045_MB,     /* BOLT High band ASM */
	QFE1045_HB,     /* BOLT High band ASM */
	QFE1055,        /* BOLT ASM */
	QFE1320,
	QFE1510,
	QFE1520,
	QFE1550,
	QFE2080FC,
	QFE2081FC,
	QFE2082FC,
	QFE2085FC,
	QFE2310,
	QFE2320,
	QFE2320EPT,
	QFE2340,
	QFE2340FC,
	QFE2520,
	QFE2550,
	QFE2720,
	QFE3320,        /* BOLT Low/Mid band PA*/
	QFE3320_EPT,    /* BOLT EPT PA */
	QFE3320_TDD,    /* BOLT TDD PA */
	QFE3320_GSM,    /* BOLT GSM PA */
	QFE3320_LB,     /* BOLT Low Band ASM */
	QFE3320_MB,     /* BOLT Mid band ASM */
	QFE3320_TX,     /* BOLT TX ASM */
	QFE3340FC,
	QFE3340FC_TDD,
	QFE3335,        /* BOLT Low band PA */
	QFE3335_ET,     /* BOLT Low band ET PA */
	QFE3345,        /* BOLT Mid band PA */
	QFE3345_ET,     /* BOLT Mid band ET PA */
	QFE3440FC,
	QFE3440FC_TDD,
	QFE4320,
	QFE4320_ET,
	QFE4320_EPT,
	QFE4320_TDD,
	QFE4320_GSM,
	QFE4320_LB,
	QFE4320_MB,
	QFE4320_TX,
	QPA4340,
	QPA4340_ET,
	QPA4340_TDD,
	QFE4335,
	QFE4345,
	QFE4373FC,
	QFE4373FC_GSM,
	QFE4435FC,
	QPA2820,
	QSW2820,
	QSW2820A,
	QPA2620,
	QPA2620A,
	QPA2630,
	QSW2630,
	QPA2640,
	QSW2640,
	QSW2640_MB,
	QSW8820,
	QSW8870,
	RPA4620,
	RPA4621,
	RPA4630,
	RPA4640,
	QFE4455FC,
	QFE4455FC_GSM,
	QFE4465FC,
	QFE4465FC_GSM,
	QFE4465FC_TDD,
	QPA4360,
	QPA4360_GSM,
	QPA4361,
	QPA4361_GSM,
	QPA5460,
	QPA5460_GSM,
	QPA5461,
	QPA5461_GSM,
	QPA5463,
	QPA5463_GSM,
	QPA8820GSM,
	QPA8820LTE,
	QPA8573,
	QPA8573_GSM,
	QPA8573_HB,
	QPA8673,
	QPA8675,
	QPA8685,
	QPA8870,
	QPA8871,
	QSW8574,
	QSW8574_LB,
	QSW8574_MB,
	QFE_ASM,
	QFE_ASM_TDD,
	QFE_PA,
	QFE_PA_GSM,
	QFE_COUPLER,
	QFE_PHYSICAL,

	/* QLN Devices */
	QLN1030,
	QLN1020,
	QLN1035,


	/*QAT devices*/
	QAT3550,
	QAT3522,
	QAT3514,
	QAT3516,
	QAT3518,
	QAT3519,
	QAT5515,
	QAT5516,
	QAT3555,

	/* Other */
	RTR8600,
	RTR9205,
	QFE_DEVICE_ALT_PART, /*Enum to be used to handle QFE ALT PART in RFC */
	WFR1620,
	WFR2600,
	WGR7640,
	TRX_HDET,
	TRX_THERM,
	TUNER_HDET,
	TP_TUNER,
	TP_BUFFER,
	RFDEVICE_MAX_NUM,
	RFDEVICE_INVALID = 0xFFFFFFFF
} rfdevice_id_enum_type;

int main()
{
	std::cout << "Hello World!\n";
	rfdevice_id_enum_type a;
	a = QET5100;
	int b = 500;
	std::cout << a;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

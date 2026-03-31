#pragma once

#ifndef EXT_MIGHTYZAP
#ifdef DLL_BUILD
#define EXT_MIGHTYZAP __declspec(dllexport)
#else
#define EXT_MIGHTYZAP __declspec(dllexport)
#endif
#endif


#pragma once
#include <Windows.h>
#include <atlstr.h>

#define PROTOCOL_TX_BUF_SIZE   50
#define  PROTOCOL_RX_BUF_SIZE  50
#define  MIGHTYZAP_PING  0xf1
#define  MIGHTYZAP_READ_DATA  0xf2
#define  MIGHTYZAP_WRITE_DATA  0xf3
#define  MIGHTYZAP_REG_WRITE  0xf4
#define  MIGHTYZAP_ACTION  0xf5
#define  MIGHTYZAP_RESET  0xf6
#define  MIGHTYZAP_RESTART  0xf8
#define  MIGHTYZAP_FACTORY_RESET  0xf9
#define  MIGHTYZAP_SYNC_WRITE  0x73 


class MightyZap
{
public:

	unsigned char ActuatorID;

	unsigned char TxBuffer[PROTOCOL_TX_BUF_SIZE];
	unsigned char TxBuffer_index;
	unsigned char RxBuffer[PROTOCOL_RX_BUF_SIZE];
	unsigned char RxBuffer_size;


	EXT_MIGHTYZAP MightyZap();
	EXT_MIGHTYZAP MightyZap(unsigned char id);
	EXT_MIGHTYZAP ~MightyZap();
	EXT_MIGHTYZAP void SerialTimeout(DWORD ReadIntervalTimeout, DWORD ReadTotalTimeoutMultiplier, DWORD ReadTotalTimeoutConstant,
		DWORD WriteTotalTimeoutMultiplier, DWORD WriteTotalTimeoutConstant);

public:
	//Protocol
	void SetProtocolHeader();
	void SetProtocolInstruction(unsigned char ins);
	void AddProtocolFactor(unsigned char para);
	void SetProtocollength_checksum();
	void SendPacket();
	int ReceivePacket(unsigned char *para, unsigned char size);


	//System Function
	EXT_MIGHTYZAP unsigned char  getID(); 
	EXT_MIGHTYZAP void setID(unsigned char id);

	EXT_MIGHTYZAP void ping(unsigned char id);
	EXT_MIGHTYZAP void ping();
	EXT_MIGHTYZAP void read_data(unsigned char id, unsigned char addr, unsigned char size);
	EXT_MIGHTYZAP void read_data(unsigned char addr, unsigned char size);
	EXT_MIGHTYZAP void read_data_model_num(unsigned char id);
	EXT_MIGHTYZAP void write_data(unsigned char id, unsigned char addr, unsigned char *data, unsigned char size);
	EXT_MIGHTYZAP void write_data(unsigned char addr, unsigned char *data, unsigned char size);
	EXT_MIGHTYZAP void WritePacket(unsigned char *Buffer, unsigned char size);
	EXT_MIGHTYZAP void WriteByte(byte data);
	EXT_MIGHTYZAP void sync_write_data(unsigned char addr, unsigned char *data, unsigned char size);
	EXT_MIGHTYZAP void reg_write(unsigned char id, unsigned char addr, unsigned char *data, unsigned char size);
	EXT_MIGHTYZAP void reg_write(unsigned char addr, unsigned char *data, unsigned char size);
	EXT_MIGHTYZAP void action(unsigned char id);
	EXT_MIGHTYZAP void action();
	EXT_MIGHTYZAP void reset_write(unsigned char id, unsigned char option);
	EXT_MIGHTYZAP void reset_write(unsigned char option);
	EXT_MIGHTYZAP void Restart(unsigned char id);
	EXT_MIGHTYZAP void Restart();
	EXT_MIGHTYZAP void factory_reset_write(unsigned char id, unsigned char option);
	EXT_MIGHTYZAP void factory_reset_write(unsigned char option);


	//API
	EXT_MIGHTYZAP bool OpenMightyZap(LPCTSTR  portname, DWORD BaudRate);
	EXT_MIGHTYZAP void CloseMightyZap();
	EXT_MIGHTYZAP void GoalPosition(int bID, short position);
	EXT_MIGHTYZAP void GoalCurrent(int bID, short speed);
	EXT_MIGHTYZAP void GoalSpeed(int bID, short curr);
	EXT_MIGHTYZAP void SetShortStrokeLimit(int bID, short position);
	EXT_MIGHTYZAP void SetLongtStrokeLimit(int bID, short position);
	EXT_MIGHTYZAP void GetShortStrokeLimit(int bID, short &pose);
	EXT_MIGHTYZAP void GetLongStrokeLimit(int bID, short &pose);
	EXT_MIGHTYZAP void Acceleration(int bID, unsigned char acc);
	EXT_MIGHTYZAP void Deceleration(int bID, unsigned char dec);
	EXT_MIGHTYZAP void PresentPosition(int bID, short &pose);
	EXT_MIGHTYZAP void ForceEnable(int bID, bool enable);
	EXT_MIGHTYZAP void SetShutDownEnable(int bID, unsigned char flag);
	EXT_MIGHTYZAP void GetShutDownEnable(int bID, unsigned char &flag);
	EXT_MIGHTYZAP void SetErrorIndicatorEnable(int bID, unsigned char flag);
	EXT_MIGHTYZAP void GetErrorIndicatorEnable(int bID, unsigned char &flag);
	EXT_MIGHTYZAP void ReadError(int bID, unsigned char &error);
	EXT_MIGHTYZAP void echo(int bID, unsigned char &error);
	EXT_MIGHTYZAP void Write_Addr(unsigned char bID, unsigned char addr, unsigned char size, short data);
	EXT_MIGHTYZAP void Read_Addr(unsigned char bID, unsigned char addr, unsigned char size, short &data);

};

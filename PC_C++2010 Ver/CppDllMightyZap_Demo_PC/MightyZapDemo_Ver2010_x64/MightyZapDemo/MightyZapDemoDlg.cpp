
// MightyZapDemoDlg.cpp : implementation file
//

#include "stdafx.h"
#include "MightyZapDemo.h"
#include "MightyZapDemoDlg.h"
#include "afxdialogex.h"

#include "../lib_x64/CppDllMightyZap_Ver2010.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMightyZapDemoDlg dialog

int isOpen=0;
MightyZap *mightyzap = new MightyZap;

CMightyZapDemoDlg::CMightyZapDemoDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CMightyZapDemoDlg::IDD, pParent)
	, m_nPosition(0)
	, m_nSettingPort(_T(""))
	, m_nSettingBaud(0)		
	, m_nServoID(0)
	, m_nSStrokeLimit(0)
	, m_nLStrokeLimit(0)
	, m_nAddrWrite(0)
	, m_nBytesWrite(0)
	, m_nDataWrite(0)
	, m_nAddrRead(0)
	, m_nBytesRead(0)
	, error(0)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	m_nSpeed = 0;
	//  m_nGoalCurrent = 0;
	m_nCurrent = 0;
}

void CMightyZapDemoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);

	DDX_CBString(pDX, IDC_PORT, m_nSettingPort);
	DDX_CBIndex(pDX, IDC_BAUDRATE, m_nSettingBaud);
	DDX_Text(pDX, IDC_Position, m_nPosition);
	DDV_MinMaxInt(pDX, m_nPosition, -1, 4095);	
	DDX_Text(pDX, IDC_ServoID, m_nServoID);
	DDX_Text(pDX, IDC_ShortStrokeLimit, m_nSStrokeLimit);
	DDX_Text(pDX, IDC_LongStrokeLimit, m_nLStrokeLimit);
	DDV_MinMaxInt(pDX, m_nLStrokeLimit, -1, 4095);
	DDV_MinMaxInt(pDX, m_nSStrokeLimit, -1, 4095);
	DDX_Text(pDX, IDC_AddrWrite, m_nAddrWrite);
	DDX_Text(pDX, IDC_BytesWrite, m_nBytesWrite);
	DDX_Text(pDX, IDC_DataWrite, m_nDataWrite);
	DDX_Text(pDX, IDC_AddrRead, m_nAddrRead);
	DDX_Text(pDX, IDC_BytesRead, m_nBytesRead);

}

BEGIN_MESSAGE_MAP(CMightyZapDemoDlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_Connecnt, &CMightyZapDemoDlg::OnBnClickedConnecnt)
	ON_BN_CLICKED(IDC_GaolPosition, &CMightyZapDemoDlg::OnBnClickedGaolposition)
	ON_BN_CLICKED(IDC_BUTTON3, &CMightyZapDemoDlg::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &CMightyZapDemoDlg::OnBnClickedButton4)
	ON_BN_CLICKED(IDC_BUTTON5, &CMightyZapDemoDlg::OnBnClickedButton5)
	ON_BN_CLICKED(IDC_BUTTON6, &CMightyZapDemoDlg::OnBnClickedButton6)
	ON_BN_CLICKED(IDC_BUTTON7, &CMightyZapDemoDlg::OnBnClickedButton7)
	ON_BN_CLICKED(IDC_ErrorDisp, &CMightyZapDemoDlg::OnBnClickedErrordisp)
	ON_BN_CLICKED(IDC_SH_Error_Read, &CMightyZapDemoDlg::OnBnClickedShErrorRead)
	ON_BN_CLICKED(IDC_SH_Error_Write, &CMightyZapDemoDlg::OnBnClickedShErrorWrite)
	ON_BN_CLICKED(IDC_Force_Off, &CMightyZapDemoDlg::OnBnClickedForceOff)

END_MESSAGE_MAP()


// CMightyZapDemoDlg message handlers

BOOL CMightyZapDemoDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CMightyZapDemoDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CMightyZapDemoDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CMightyZapDemoDlg::ErrorRead()
{	
	CheckDlgButton(IDC_InsError,error&0x40);
	CheckDlgButton(IDC_OverloadError,error&0x20); 
	CheckDlgButton(IDC_CheckSumError,error&0x10);
	CheckDlgButton(IDC_RangeError,error&0x08);
	CheckDlgButton(IDC_StrokeLimitError,error&0x02);
	CheckDlgButton(IDC_InputVoltageError,error&0x01);

}

int SellectBaudrate(int baud)
{
	int Baudrate;
	switch(baud)
	{
		case 0 : Baudrate = CBR_9600; break;
		case 1 : Baudrate = CBR_19200; break;
		case 2 : Baudrate = CBR_57600; break;
		case 3 : Baudrate = CBR_115200; break;
	}
	return Baudrate;
}


void CMightyZapDemoDlg::OnBnClickedConnecnt()
{
	// TODO: Add your control notification handler code here
		// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	CString p_name;
	short data;
	CString str;
	if(isOpen==0) {				
		if(mightyzap->OpenMightyZap(m_nSettingPort,SellectBaudrate(m_nSettingBaud))!=TRUE) {
			MessageBox (NULL, TEXT("사용중인 PORT 입니다."));
			return;
		}		
		//mightyzap->SerialTimeout(100,100,100,100,100);
		
		GetDlgItem(IDC_Connecnt)->SetWindowTextW(L"Disconnect");
		GetDlgItem(IDC_PORT)->EnableWindow(FALSE);
		GetDlgItem(IDC_BAUDRATE)->EnableWindow(FALSE);
		isOpen=1;
	
		mightyzap->PresentPosition(m_nServoID, data);
		str.Format(L"%d", data);
		GetDlgItem(IDC_PresentPosition)->SetWindowText(str);
		GetDlgItem(IDC_Position)->SetWindowText(str);  

		mightyzap->GetShortStrokeLimit(m_nServoID, data);
		str.Format(L"%d", data);
		GetDlgItem(IDC_ShortStrokeLimit)->SetWindowText(str);

		mightyzap->GetLongStrokeLimit(m_nServoID, data);
		str.Format(L"%d", data);
		GetDlgItem(IDC_LongStrokeLimit)->SetWindowText(str);

	

		unsigned char ShutDownError;
		mightyzap->GetShutDownEnable(m_nServoID, ShutDownError);

		CheckDlgButton(IDC_SH_InsError, ShutDownError & 0x40);
		CheckDlgButton(IDC_SH_OverloadError, ShutDownError & 0x20);
		CheckDlgButton(IDC_SH_CheckSumError, ShutDownError & 0x10);
		CheckDlgButton(IDC_SH_RangeError, ShutDownError & 0x08);
		CheckDlgButton(IDC_SH_StrokeLimitError, ShutDownError & 0x02);
		CheckDlgButton(IDC_SH_InputVoltageError, ShutDownError & 0x01);
	}else {
		mightyzap->CloseMightyZap();

		GetDlgItem(IDC_Connecnt)->SetWindowTextW(L"Connect");
		GetDlgItem(IDC_PORT)->EnableWindow(TRUE);
		GetDlgItem(IDC_BAUDRATE)->EnableWindow(TRUE);

		isOpen=0;
	}
}



void CMightyZapDemoDlg::OnBnClickedGaolposition()
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	mightyzap->GoalPosition(m_nServoID,m_nPosition); 
	CheckDlgButton(IDC_Force_Off,false);

	Sleep(1);
	
	// Read Error
	mightyzap->ReadError(m_nServoID,error);
	ErrorRead();
}


void CMightyZapDemoDlg::OnBnClickedButton3()
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	//                   Servo ID  Addr byte  data
	mightyzap->Write_Addr(m_nServoID, 0x06,   2, m_nSStrokeLimit);
}


void CMightyZapDemoDlg::OnBnClickedButton4()
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	//                   Servo ID  Addr byte  data
	mightyzap->Write_Addr(m_nServoID, 0x08,   2, m_nLStrokeLimit);
}


void CMightyZapDemoDlg::OnBnClickedButton5()
{
	// TODO: Add your control notification handler code here
	short data;
	CString str;
	UpdateData(TRUE);
	mightyzap ->PresentPosition(m_nServoID,data);	

	str.Format(L"%d",data);	
	GetDlgItem(IDC_PresentPosition)->SetWindowText(str);

	// Read Error <- 수신 버퍼에서 error 읽어오기
	error = mightyzap->RxBuffer[5];
	ErrorRead();

}


void CMightyZapDemoDlg::OnBnClickedButton6()
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);	
	mightyzap->Write_Addr(m_nServoID, m_nAddrWrite, m_nBytesWrite, m_nDataWrite);

	// Read Error
	mightyzap->ReadError(m_nServoID,error);
	ErrorRead();
}


void CMightyZapDemoDlg::OnBnClickedButton7()
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);	
	short data;
	CString str;
	mightyzap->Read_Addr(m_nServoID, m_nAddrRead, m_nBytesRead,data);
	str.Format(L"%d",data);
	GetDlgItem(IDC_DataRead)->SetWindowText(str);

	// error 값 buffer에서 읽어오기 
	error = mightyzap->RxBuffer[5];
	ErrorRead();
}

void CMightyZapDemoDlg::OnBnClickedErrordisp()
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	mightyzap->ReadError(m_nServoID,error);
	CheckDlgButton(IDC_InsError,error&0x40);
	CheckDlgButton(IDC_OverloadError,error&0x20); 
	CheckDlgButton(IDC_CheckSumError,error&0x10);
	CheckDlgButton(IDC_RangeError,error&0x08);
	CheckDlgButton(IDC_StrokeLimitError,error&0x02);
	CheckDlgButton(IDC_InputVoltageError,error&0x01);
}


void CMightyZapDemoDlg::OnBnClickedShErrorRead()
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	unsigned char ShutDownError;
	mightyzap->GetShutDownEnable(m_nServoID,ShutDownError);
	
	CheckDlgButton(IDC_SH_InsError,ShutDownError&0x40);
	CheckDlgButton(IDC_SH_OverloadError,ShutDownError&0x20); 
	CheckDlgButton(IDC_SH_CheckSumError,ShutDownError&0x10);
	CheckDlgButton(IDC_SH_RangeError,ShutDownError&0x08);
	CheckDlgButton(IDC_SH_StrokeLimitError,ShutDownError&0x02);
	CheckDlgButton(IDC_SH_InputVoltageError,ShutDownError&0x01);
}


void CMightyZapDemoDlg::OnBnClickedShErrorWrite()
{
	// TODO: Add your control notification handler code here
		UpdateData(TRUE);
	unsigned char ShutDownError=0;


	if(IsDlgButtonChecked(IDC_SH_InputVoltageError)) ShutDownError|=0x01;
	if(IsDlgButtonChecked(IDC_SH_StrokeLimitError)) ShutDownError|=0x02;
	if(IsDlgButtonChecked(IDC_SH_RangeError)) ShutDownError|=0x08;
	if(IsDlgButtonChecked(IDC_SH_CheckSumError)) ShutDownError|=0x10;
	if(IsDlgButtonChecked(IDC_SH_OverloadError)) ShutDownError|=0x20;
	if(IsDlgButtonChecked(IDC_SH_InsError)) ShutDownError|=0x40;	
	
	mightyzap->SetShutDownEnable(m_nServoID, ShutDownError);

}


void CMightyZapDemoDlg::OnBnClickedForceOff()
{
	// TODO: Add your control notification handler code here
		BOOL bCheck = ((CButton*)GetDlgItem(IDC_Force_Off))->GetCheck();
	if(bCheck)
	{		
		mightyzap->ForceEnable(m_nServoID,0);		
	}else {
		mightyzap->ForceEnable(m_nServoID,1);	
	}
}




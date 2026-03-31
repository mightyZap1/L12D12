
// MightyZapDemoDlg.h : header file
//

#pragma once



// CMightyZapDemoDlg dialog
class CMightyZapDemoDlg : public CDialogEx
{
// Construction
public:
	CMightyZapDemoDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_MIGHTYZAPDEMO_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:	
	afx_msg void OnBnClickedButton1();
	CString m_nSettingPort;
	int m_nSettingBaud;
	afx_msg void OnBnClickedConnecnt();
	int m_nPosition;
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedGaolposition();
	int m_nServoID;
	afx_msg void OnBnClickedButton3();
	int m_nSStrokeLimit;
	afx_msg void OnBnClickedButton4();
	int m_nLStrokeLimit;
	afx_msg void OnBnClickedButton5();
	afx_msg void OnBnClickedButton6();
	int m_nAddrWrite;
	int m_nBytesWrite;
	int m_nDataWrite;
	int m_nAddrRead;
	int m_nBytesRead;
	afx_msg void OnBnClickedButton7();
	afx_msg void OnBnClickedButton8();
	afx_msg void OnBnClickedErrordisp();
	unsigned char error;
	void ErrorRead();
	afx_msg void OnBnClickedShErrorRead();
	afx_msg void OnBnClickedShErrorWrite();
	afx_msg void OnBnClickedForceOff();

	int m_nSpeed;

	int m_nCurrent;
};

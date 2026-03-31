
// MightyZapDemo_x64Dlg.h : 헤더 파일
//

#pragma once


// CMightyZapDemo_x64Dlg 대화 상자
class CMightyZapDemo_x64Dlg : public CDialogEx
{
// 생성입니다.
public:
	CMightyZapDemo_x64Dlg(CWnd* pParent = NULL);	// 표준 생성자입니다.

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MightyZapDemo_x64_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 지원입니다.


// 구현입니다.
protected:
	HICON m_hIcon;

	// 생성된 메시지 맵 함수
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedConnect();
	CString m_nSettingPort;
	int m_nSettingBaud;
	int m_nServoID;
	afx_msg void OnBnClickedGoalposition();
	int m_nPosition;
	void ErrorRead();
	unsigned char error;
	afx_msg void OnBnClickedBtnSstrokelimit();
	int m_nSStrokeLimit;
	int m_nLStrokeLimit;
	afx_msg void OnBnClickedBtnLstrokelimit();
	afx_msg void OnBnClickedBtnPresentposition();
	afx_msg void OnBnClickedBtnAddrwrite();
	int m_nAddrRead;
	int m_nAddrWrite;
	int m_nBytesRead;
	int m_nBytesWrite;
	int m_nDataWrite;
	afx_msg void OnBnClickedBtnAddrread();
	afx_msg void OnBnClickedReaderror();
	afx_msg void OnBnClickedReadshutdown();
	afx_msg void OnBnClickedWriteshutdowm();
};

'모두접기 Alt+0 / 모두펼치기 Alt+Shift+0 / 기호 양식순서 1. -> 1) -> (1)

imports http://converter.telerik.com/ 'C# <-> VB Code Convert

Public Class vb
	
	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
		call command()
		call visualStudioShortCutKey()
		call notePad()
		
	End Sub

	Private sub command()
		
		1.변수선언
			Dim AA As Integer
			Dim BB As String()
			Dim ds As DataSet = New dataset
			Dim Params As Object = Nothing
			Dim arr2 As String()()
		2.함수인자
			ByVal AA As Integer
			ByRef AA As Integer
		3.조건문(if)
			If ResultDs.Tables("Data.Main").Rows.Count = 0 Then
				
			End If			
		4.조건문(case)
			select Case data
				Case "I"
					
				Case "U"
					
				Case "D"
				   break
				Case Else
					Continue For
			End Select
		5.반복문(for)
			For i = 0 To ResultDs.Tables("Data.Main").Rows.Count - 1
			
			Next
		6.Exit문
			Exit For
			Exit SELECT
			Exit Sub
			Exit try
		
	End Sub
	
	Private sub visualStudioShortCutKey()
		
		-기본 단축키-
		F1 : 도움말
		F2 : Refactor -> Rename
		F3 : 다음 찾기
		F4 : 속성창 보기
		F5 : 디버그 모드로 실행
		Ctrl + F5 : 디버그 없이 실행
		F6 : 전체 솔루션 빌드
		Shift F6 : 현재 프로젝트만 빌드
		F7 : 소스코드 보기
		F8 : 다음 위치로 이동(파일에서 찾기 등을 했을 경우 F8 누를때마다 다음 검색결과 위치로 이동)
		F9 : breakpoint toggle
		F10 : 메서드 콜을 따라가지 않는 라인단위 디버그
		F11 : 메서드 콜이 있는 경우 메서드 내부로 이동하는 디버그
		F12 : 정의로 이동

		-소스코드 탐색-
		F12
		정의로 이동(Go to Definition)
		
		Ctrl + "-" 또는 Ctrl + Shift + 8
		이전 위치로 이동(Pop Browse Context)
		F12로 이동했다가 다시 원래 위치로 돌아가기 위해서 사용한다.
		웹브라우저의 Back기능과 유사

		Ctrl + Shift + "-"
		Ctrl + "-"의 반대.
		웹브라우저의 Forward기능과 유사

		Shift + F12
		특정 변수위에 커서를 두고 Shift + F12를 누르면 동일한 변수명을 가지고 있는 모든 부분을 검색해 준다.

		Ctrl + Alt + 방향키
		Ctrl + Tab키와 비슷하지만 훨씬 더 편리하다.
		단축키를 누르면 오른쪽 상단에 현재 열려있는 파일 목록이 나오고 방향키로 이동하면서 파일을 선택할 수 있다.

		Ctrl + Shift + F, Ctrl + Shift + H
		파일에서 찾기, 파일에서 바꾸기

		F7, Shift + F7
		소스코드 보기, 디자인보기

		Shift + Alt + Enter
		전체화면 toggle

		-소스코드 정렬-

		Ctrl + K + D, Ctrl + K + F
		현재 파일의 서식(들여쓰기, 내어쓰기, 줄바꿈 등)을 Visuaul Studio의 표준 형태로 정리해 준다.
		Ctrl + K + D는 현재 파일의 모든 내용에 대하여 적용되고 Ctrl + K + F는 선택한 텍스트에 적용된다.

		Ctrl + M + L
		누를때 마다 현재 파일의 코드를 접거나 펼친다.
		Ctrl + M + M
		누를때 마다 현재 커서가 위치한 부분의 코드를 접거나 펼친다.

		-소스코드 편집-

		F2
		Refactor -> Rename 명령 수행.
		이미 존재하는 변수의 이름을 변경시에는 이렇게 하는 것이 좋다.

		Ctrl + Space 또는 Ctrl + J
		현재 커서가 위치한 곳에 IntelliSense 목록을 띄운다.
		인스턴스 변수 뒤에 "."을 찍으면 나오는 그 팝업을 원할 때 띄울 수 있다.

		Ctrl + Shift + Space
		패러미터 정보를 출력해 준다.
		메서드나 생성자 등의 패러미터를 입력하기 위해 "("를 치는 순간에 나오는 그 팝업을 원할 때 띄울 수 있다.

		Shift + Del
		현재 커서가 위치한 행을 삭제하고 그 내용은 클립보드에 복사한다. Ctrl X의 대용으로 써도 되지만 한줄을 삭제할 때 더 유용하다.

		Ctrl + K + C
		현재 커서가 위치한 행, 또는 선택한 텍스트를 주석 처리한다.

		Ctrl + K + U
		현재 커서가 위치한 행, 또는 선택한 텍스트의 주석처리를 해제한다.

		Shift + Alt + 방향키
		자유로운 텍스트 선택

		Ctrl + K + S, Ctrl + K + X
		Code Snippet 팝업을 띄운다. 텍스트를 선택하지 않으면 커서가 위치한 부분에 Code Snippet이 삽입되고 텍스트를 선택한 상태라면 Code Snippet이 선택한 텍스트를 감싸게 된다.

		Ctrl + K + X를 누르면 Code Snippet을 상위의 네임스페이스부터 선택할 수 있다.

		Ctrl + K + M
		아래와 같이 현재 정의되지 않은 메서드를 호출하는 코드를 작성했을때
		
	End Sub
	
	Private sub notePad()

		**프로젝트 안뜰때
		해당 프로젝트 우클릭 기본항목추가해서 3개 추가해주면됨 이상한 이름은 지워주고
		
		**프로젝트 복사할때
		.vb 파일 3개 이름바꿔주고 프로젝트 추가해서 이름바꿔주면됨

		1.파일 옮기기
		 개발단-프로젝트(Fms-폴더),EXE(Fms-bin-Debug),RPT(Fms-RPT-폴더),LANGUEAGE(Fms-bin-Debug-폴더)
		 서버단-SQL(Webapp-app_data),BIZ(Webapp-app_code),DLL(Webapp-WCF-Client-Bin-Modules),RPT(Webapp-WCF-Client-Bin),LANGUAGE(Webapp-WCF-Client-Bin),EXE((Webapp-WCF-Client-Bin)
		 
		2.코드 설명(참조)
		1)grdi좌측에 번호생성
		 Call DrawRowIndicator(GV1)
		 
		*그리드 오토사이즈
		GV1.BestFitColumns()
		 
		*설치방법
		1.http://help.logis21.com/service2/index.asp 접속해서 로그인하고
		2.1,2,3번 설치를 한다.
		3.oracle 9i 설치안될때는 oracle 11로 설치한다
		4.설치할때는 사용자로 체크해서 설정하던가,관리자로 설치
		5.tnsname 깔고
		6.logis 폴더만들어서 logis 폴더안에 설정하고
		7.windows안에 inf 파일 넣어줘야됨
		 
		*화면추가후 sin 파일 올리기
		*메인폼을 바꾸면 .app 안에있는 mainform.designer 올리기
		 
		1)화면에 있는 그리드값 가지고 오기
		Dim tempDs As DataSet = Me.ConvertToDataset 

		2')해당안되는 그리드 제외시키기
		For i = 0 To GV1.RowCount - 1
							If tempDs.Tables("DETAIL").Rows(i)("CHK") = "N" Then
								tempDs.Tables("DETAIL").Rows(i).Delete()
							End If
						Next
		exit for
		
		*테이블 삭제
		 ds.Tables.Remove("Table")              

		**데이터셋,데이터테이블,데이터로우 기본명령어
		-datarow-
		drHeader = ds.Tables("MAIN").Rows(0) - 데이터셋 메인테이블의 0번째 행을 데이터로우로 넣기
		drHeader = dt.Rows(0) - 데이터테이블의 0번째 행을 데이터로우로 넣기

		**데브에러
		윈도우 10 에러나면 윈도우7로 깔아야함

		**dt.row.count 에러나면
		dt Is Nothing 로 바꾸면됨

		-datatable-
		dt.TableName = "MAIN" - 테이블이름 메인으로 설정
		Dt = ds.Tables("WG1").Copy() - 데이터셋의 WG1테이블을 카피해서 데이터테이블에 넣기
		dt.clear  - 데이터테이블 데이터값 클리어 (헤더값은 남아있음)
		Dt.ImportRow(ds.Tables("WG1").Rows(index)) - 데이터테이블에 로우 삽입
		dt = WG1.DataSource.Copy - 데이터테이블에 그리드의 모든값을 카피해서 삽입
		dt.rows(i).delete() - 데이터테이블의 i번째 행을 삭제

		-dataset-
		resDs.Tables.Add(dt) - 데이터셋에 dt데이터테이블 추가
		ds = ConvertToDataset() - ds에 화면에있는 모든값 담기
		ds.Merge(dt) - 기존의 값에 테이블에 있는값 합치기(병합)

		-row.delete 하면 값은 지워지고 rowstate 는 delete로 남게된다 
		ex)
		Dim dt As DataTable = Nothing
				dt = ds.Tables("WG1").Copy '데이터 복사붙여넣기

				For index = 0 To dt.Rows.Count - 1 '그리드 쓰레기값 제거하기
					If dt.Rows(index)("INV_NO").ToString = "" And dt.Rows(index)("CUSTOM_CAR_NO").ToString = "" And dt.Rows(index)("CHK").ToString = "N" Then
						dt.Rows(index).Delete()
					End If
				Next

				ds.Tables("WG1").Clear() '기존 테이블 데이터 초기화

				For index = 0 To dt.Rows.Count - 1 '조건만족하는것만 다시 집어넣기
					If dt.Rows(index).RowState <> DataRowState.Deleted Then
						ds.Tables("WG1").ImportRow(dt.Rows(index))
					End If

				Next
				
		----------------------------------------------------------------------------------

		!!데이터셋 화면에 바인딩 시킬때
		Me.BindToDataset(dataset, "Data") - 단 테이블명이 WG1 이런식으로 되어있으면 바인딩 안되고 Data.WG1 이런식으로 되어있어야 바인딩됨

		!!데이터포맷 FORMAT
		Format(CDec(dr("TS_YMD")), "####-##-##") => '20180101' ->'2018-01-01'

		!!DECODE 형식(IIF)
		IIF(something Is Nothing, "nothing", something.Value)

						
		3)Combobox,Codebox,ComboCheckBox (좌표:webapp-Appcode-YJIT.CodeService-CommonCode) 
		 Combobox-list()->출력
		 CodeBox->Search->Search()->그리드 클릭->Validate()->출력
		 ComboCheckBox: Shwon->FreightLookup()->CodeService(FreightLookup)->출력
		 
		4)우클릭 팝업
		 PopupInit()
		 {Dim PopUp As New PopupBase
				PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "&Add Row")
				PopUp.ItemAdd(Action.DeleteRow, "WG1_DeleteRow", "&Delete Row")
				PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "&Excel Export", True)
				PopUp.PopUpInit(Me, WG1, "WH_CD")}
		 
		5)그리드 설정(그리드 내부 Codebox,Combobox 등등 기능집어넣기)
		 InitGrid()
		{Dim dtComboSource As DataTable
				Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
				'Dim editorCode As YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
				Dim searchParams As Dictionary(Of String, Object)
				Dim dataParams As Dictionary(Of String, Object)

				'==================Grid1============================
				'Warehouse type
				editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
				editorCombo.DisplayMember = "NAME"
				editorCombo.ValueMember = "CODE"
				editorCombo.NullText = "--Select--"
				searchParams = New Dictionary(Of String, Object)
				dataParams = New Dictionary(Of String, Object)
				dataParams.Add("GroupCode", "M16")
				dataParams.Add("NameType", "")
				editorCombo.ShowHeader = False
				editorCombo.ReadOnly = False
				editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
				GV1.Columns("WH_TYPE").ColumnEdit = editorCombo}
		 
		3.RPT
		 -루프돌릴거는 Detail안에다가 만들면된다. 만들고나서 꼭대기 속성 Data-Data Member안에있는 속성을 해당 그룹으로 정해줘야됨
		 
		 
		4.Language
		 1)프로젝트 Language는 Localizing Word ID 속성에 맞게 따라간다.
		 2)(실행화면)Language추가할때는 System-Dictionary Management-검색 후 변경 또는 생성하고 Save-Build탭에서 언어선택하고 Build하면 dll 생성됨
		 생성된 dll을 해당 폴더에 옮겨주면됨
		 
		5.프로젝트 복사

		-1단계-
		(modules 추가부분)

		1.프로젝트 폴더를 복사한다.
		2.폴더이름을 바꾼후 (FMS-?)에다가 저장한다.
		3.폴더안에있는 .vbproj이름을 바꿔준다.(2개)
		4.비쥬얼스튜디오에서 기존프로젝트 추가로 불러온다.
		5.프로젝트 세부보기 화살표 누른후 .vb파일도 이름바꾸기로 폴더이름과 동일하게 해준다.
		6.프로젝트 우클릭 속성을 들어가서 어셈블리 이름도 동일하게 바꿔준다.
		*코드 내부에 FormLoad 나 FormShown 등 이벤트 명도 바꿔준다.
		7.속성창을 닫고 프로젝트 우클릭해서 다시빌드를 해준다.
		8.다시빌드하면 ex)FMS-MDM-MdmKsu-obj-debug에 (?).dll파일이 생긴다.
		9.(main부분)메인화면에 메뉴 추가(Button add)하고 name을 모듈 프로젝트명하고 동일하게 맞춰준다 (TEXT와 WORD ID를 맞춰준다.)
		10.엘비스를 실행시킨다.
		11.(풀 다운)System-ProgramManagement-들어가서 modules파일을 찾아보면 (?).dll파일이 있다.
		12.더블클릭 로드 후 세이브를 하면 DB에 저장이 된다.
		13.이후 MDM-UserManagement-User Group Autority or User Autority에서 찾아서 권한추가해주면 된다.

		-2단계-
		(biz 추가부분)
		biz 파일복사해서 파일이름만 바꿔서 붙여넣어주고
		비즈코드안에 public class 이름도 같이 바꿔주면된다.

		-3단계-
		(sql 부분)
		원하는 파일 우클릭 addfile 하면 파일 만들어짐
		파일 더블클릭 후 +버튼으로 추가 -버튼으로 삭제가 가능함. 

		** grid는 run designer 들어가서 컬럼-컬럼추가하고 필드명을 db컬럼명과 같게하면 데이터가 들어간다.

		--------------------------------------------------------------------------------------------------

		(개별적 팁)
		wg1은 전체 그리드, vg1 은 개별 그리드
		링크 기능은 vg1이벤트 안에 MouseDoubbleClick 함수가 있다 거기에 있음 또는 WG1이벤트안에 Click함수 있음.
		우클릭 기능은 전체폼 Formshown이벤트 안에 PoupInit()함수가 있다 여기 함수 안에 우클릭 이벤트 페이지가 있음.
		그리드에 다른기능 추가할때는 gv1-Run Designer에 해당 컬럼 찾은후 ColumnEdit에서 찾으면됨(ex CheckBox or CheckEdit)
		CommonCode 등등 공통코드 참조할때는 위치(Webapp\App_Code\YJIT.CodeService\안에 들어가있다)
		SQL-CodeService@CommonCode
		DB-MDM_COM_CODE
		grid열 값 SUM,AVG 등등 구할때는 


		01.06---------------------------------------------------------------------------------------------
		참조:MAXMAN-MDM-Container Type Size(MdmContainerMgt.vb)

		1)Grid_CheckBox :Column생성 후 ColunEdit 설정하면됨
		2)Grid_CheckBox 복수선택 및 WG1에 체크한것만 데이터를 올리고싶을때 속성=>ColumnEdit->ValueChecked=string(Y) , ValueUnChecked=string(N) 설정하고 Field명 설정 후  Search()해서 데이터 받아올때 체크박스 값도 받아와야됨 (Y or N)
		3)그리드 옮길때는 드래그해서 옮기면 된다.
		4)grid 추가 -> WG1.AddRow() // grid 삭제 -> WG1.DeleteRow()
		5)Alt+key 쓰려면 ex)add => Word ID, Text = &Add  => Alt+A로 사용가능
		6)넓은 텍스트박스 쓰려면 ColumnEdit=>MemoEdit 사용하면됨

		!! MemoExEdit 사용하면됨 글자는 보이고싶으면 showicon=false
		7)콤보박스 데이터 가지고 올 때-> CodeType과 DataParams 지정하면됨
		8)Date박스는 날짜지정해서 보내면 ex)2017년 10월 1일 -> (data) 20171001 식으로 보낸다.
		9)숫자입력만 되게하려면 Textbox 말고 NumerictextBox를 사용해야 된다. 이후 Format설정에서 원하는 숫자형식 설정가능
		10)CodeBox사용할 때 DisplayParams설정하면된다. ex) Code:@OTH_CD,Name:@OTH_NM => Code는 OTH_CD에 입력되고 Name은 OTH_NM에 입력된다.
		 
		 *CommonCode 위치: Webapp->YJIT.CodeService->CommonCode
		  -Function-
		  1.List-ComboBox
		  2.Search-CodeBox(돋보기 클릭했을때 실행되는 함수 )
		  3.Validate-CodeBox(리스트에서 클릭했을때 실행되는 함수)
		  
		  SQL:CodeService@CommonCode 
		  DB:MDM_COM_CODE
		  
		11.Grid 컬럼라인(열)값 토탈로 구하기 = Rundeginer->Column->해당컬럼 선택->데이터(summary 있음) summary item ->max,sum 등 선택해주면됨

		12.그리드에 컬럼값 모두빼고 DataSet으로 받으면 Search한 모든데이터가 Grid에 들어간다.

		01.09---------------------------------------------------------------------------------------------
		어플리케이션(배포) YJIT.SC.FMS 게시하고
		SmartClient or 양재아이티 폴더안에 SC배포판설치 파일 참조하면 좋음
		1)배포판 도움파일 참조해서 파일생성한다
		2)Webapp-WCF파일 안에다가 넣는다 
		3)넣은 파일을 서버에다가 넣어야되는데 그 전에 IIS 등록해야된다.
		4)등록하고 넣으면됨

		IIS 설치안될경우
		윈도우 전체 업데이트 and 재부팅하면됨

		*배포 안될경우
		내컴퓨터-문서-YJIT.SC Home -파일 지우고 //프로그램 제거에서 제거한다음에 새로설치하면됨

		*또는 C드라이브 YJNET안에 폴더 지우고 새로 다운로드 하면 될듯.
		01.10---------------------------------------------------------------------------------------------
		SVN설정하는법 ADD 하고 COMMIT 하면됨
		설치경로는 REPOSTORY 안에 변환된 데이터로 저장되어있음


		01.13---------------------------------------------------------------------------------------------
		회사게시판-기술문서-VB.net-참고(다양한 내용이 있음) 사이트 : yjit.hanbiro.net 

		01.20---------------------------------------------------------------------------------------------
		1.RPT구조 참고: SCM\MBLIO01
		Biz1)BIZ단을 통해서 데이터 서치를 한다음 데이터셋에 데이터를 받아 모듈단으로 넘겨준다.
		Module2)데이터셋으로 받으면(테이블:MAIN,USERINFO,HEADERINFO.. 등등 여러개 테이블로 나뉨)
		Module3)데이터셋을 레포트(RPT)로 넘겨준다.
		Rpt4)레포트가 넘겨받으면 
		Rpt5)쿼리에 적힌대로 EX) <MAIN>   -> 데이터셋에 있는 Table명과 똑같이 맞춰야됨
													'' AS USER_ID  - 문자형일때
													 0 AS USER_PWD - 숫자형일때
			쿼리를 작성하고 CONNECT(64비트-SQL) 하고 XML 클립보드 복사버튼 클릭해서 레포트에 붙여넣어준다.
		6)그러면 데이터셋에 있는 데이터와 레포트가 링크가 걸림. 

		2.EXCEL구조 참고:SCM\HBLIO01.vb
		-UPLOAD-
		Module1)TRY-엑셀자료체크 or CATCH-에러 빠져나감
		Module2)업로드완료

		-SAVE-
		Module1) GRID값 전체를 BIZ단으로 보낸다. ME.ConvertToDataset  ex)dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.HBLIO01", "SaveExcelData", Me.ConvertToDataset)
		Biz2) Sql@ColumnMapping 을 통해 엑셀에 적힌 컬럼을 영문(실제데이터형)으로 이름을 변경시킨다.
		Biz3) Sql@MakeSONO 을 통해 채번을 해준다.
		Biz4) Sql@InsExcelOrder_ICSK를 통해 마스터테이블에 데이터를 집어넣어준다.
		Biz5) Sql@InsExcelItem 을 통해 디테일테이블에 데이터를 집어넣어준다.

		3.Mandatory 적용하기
		로그인후-MDM-Office Management-ex)좌측에 ICSKOREA HEAD OFFICE 안에 ICS KOREA AQ 안에 ICS KOREA의 4번째 탭(Mandatory Item)에 항목만들어서 추가해야됨

		4.데이터테이블 값 확인
		If dt IsNot Nothing Then ~~ Else ~~ End If          

		5.데이터셋에 컬럼추가 및 값넣기
		ds.Tables("MAIN").Columns.Add("S_CUST_GRP")
		ds.Tables("MAIN").Rows(0)("S_CUST_GRP") = S_CUST_GRP.EditValue

		6.그리드 로우값 없을때 빠져나가기
		  If GV1.RowCount = 0 Then
					Exit Sub
				End If
						
		7.조건 만족못하는 테이블 로우값은 제거
										Dim tempDs As DataSet = Me.ConvertToDataset
						tempDs.Tables("WG1").TableName = "DETAIL"
						For i = 0 To GV1.RowCount - 1
							If tempDs.Tables("DETAIL").Rows(i)("CHK") = "N" Then
								tempDs.Tables("DETAIL").Rows(i).Delete()
							End If
						Next
						
						
		8.수정된 그리드값 가지고오기
		Dim ds As DataSet = Me.ConvertToDataset

		9.수정안된 그리드 수정된 값으로 변경(converttodataset 했을때 모든 데이터를 가지고오고싶을경우)
		For i = 0 To GV1.RowCount - 1
						If GV1.GetDataRow(i).RowState = DataRowState.Unchanged Then
							GV1.GetDataRow(i).SetModified()
						End If
					Next
					
		10.OfficeCode 와 HqOfficeCode 값 가지고오기
			  ClientSessionInfo.OfficeCode = "TSLHQ" -오피스코드 맞는지 조건부 체크
			ClientSessionOfficeInfo.HqOfficeCode = "TSLHQ" - Hq오피스코드 맞는지 조건부 체크
			YJIT.SessionInfo.UserID - userid 가지고오기
			//YJIT.~~ 은 App_Code 안에 있고 일반은 YJIT.SC.App안에 Common 안에 있다.
			
		11.제일 간단한 biz단 sql 호출->파라미터넘김->데이터베이스에 쿼리던지기->데이터테이블 생성
									  Dim sql As New SqlBox("StlInvoiceList@SearchMain")
						sql.Params("INV_GRP_NO") = drHeader("S_INV_GRP_NO").ToString
						sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
						Dim dt As DataTable = db.SqlGet(sql.Text, False)
						dt.TableName = "MAIN"
						resultDs.Tables.Add(dt)
					  
		12.grid 값 설정 (코드)
		Me.GV1.Columns(index).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center-중앙정렬 (헤더말고 셀은 AppearanceCell)
		Me.GV1.Columns(index).AppearanceHeader.Options.UseTextOptions = True -?
		Me.GV1.BestFitColumns() - 출력되는 데이터크기에맞게 길이설정
		Me.GV1.Columns(index).Visible = False - 컬럼안보이게 설정
		Me.GV1.Columns(0).ColumnEdit = Me.RepositoryItemCheckEdit1 - 첫번째 컬럼을 체크박스로 바꿈

		-블럭 열기-
		sql.Blocks("BILG_CURR_YES") = True

		-파라미터 값 넣기-
		sql.Params("MBL_NO") = drHeader("S_MBL_NO").ToString

		13.데이터헤더로 테이블 첫번째 로우값만 받아오기
		drHeader = ds.Tables("MAIN").Rows(0)

		14.통합메뉴관리
		login)System-MenuManagement

		15.그리드에 체크값 없을때 반환
		Dim chkcnt As Integer = 0

				For I = 0 To GV1.RowCount - 1
					If GV1.GetRowCellValue(I, "CHK") = "Y" Then
						If GV1.GetDataRow(I).RowState = DataRowState.Unchanged Then GV1.GetDataRow(I).SetAdded()
						chkcnt += 1
					Else
						GV1.GetDataRow(I).AcceptChanges()
					End If
				Next
				
				If chkcnt = 0 Then
					MsgBox("출력할 번호를 선택하세요.")
					Exit Sub
				End If
				
		16.Print구조-참조:ICSK-StlInvoiceList2
		Modules)Print_CI()- GetRptPrint()호출
		Modules)GetPrint() - Biz단으로 그리드값 받아서 데이터셋으로 넘겨줌
		Biz)Print_CI() - 쿼리수행후 데이터셋 반환
		Modules)GetRptPrint() - 데이터셋을 받으면 rpt페이지를 생성후 반환해준다.
		Modules)Print_CI() - RPT를 반환받으면 RPT를 생성한다.

		17.코드에서 키를 임의로 입력할때
		SendKeys.Send("^Z")

		SendKeys.Send("{ENTER}")

		**그리드 Ctrl+F 없애기
		FGV2.HideFindPanel()

		18.그리드에 복붙하기 참고 -ExpTariffMgt-GV2_KeyDown

		19.그리드 Cntl+A 해서 복사까지 하기 -ExpTariffMgt-GV1_KeyDown

		01.31---------------------------------------------------------------------------------------------

		1.출력물 여러장 뽑을수있게 만들기(참고:ICSK-StlInvoiceList2-PrintList)!!중요**

		-GetRptPrint-
		Dim Dt As DataTable = New DataTable() 데이터테이블 생성
		Dt = ds.Tables("WG1").Copy() Dt에 데이터셋(ds)에있는 WG1테이블을 Dt에 통채로 카피(모든데이터값까지 다들어감)
				Dt.TableName = "Data.DETAIL" Dt의 테이블명을 Data.DETAIL로 변경
				Dt.Clear() Dt의 테이블형식은 유지한채 안에있는 데이터만 지움
		Dt.ImportRow(ds.Tables("WG1").Rows(index)) 조건만족하는 데이터 로우만 Dt테이블에 담는다 
		dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.StlInvoiceList2", "Print_CI", {ds, i}) Biz단에 데이터를 넘겨주고 데이터셋으로 반환받음
		dsRet.Tables.Add(Dt.Copy()) 반환받은 데이터셋(dsRet)에 테이블을 추가해준다.

		Dim rpt2 As New DevExpress.XtraReports.UI.XtraReport
		rpt2.LoadLayout(Common.ReportPath & "\STL\StlInvoiceList2.repx") -레포트 경로지정
		rpt2.DataSource = Common.AdaptDataSourceForReport(dsRet) - 데이터소스 dsRet적용
		rpt2.CreateDocument()
		rpt.Pages.AddRange(rpt2.Pages)

		모든설정이 끝나면 Return rpt를 해준다.

		-Print_CI-
		Dim rpt As DevExpress.XtraReports.UI.XtraReport = GetRptPrint() 반환밭은 rpt를 변수에 담고
		ReportPrintTool(rpt) 출력을해준다.

		2.Run Designer -모양(VisibleIndex)가 낮은순으로 왼쪽정렬된다.(디자인화면에서 드래그해도 인덱스 변경됨)
			!왼쪽고정으로설정하려면 동작(Fixed)=Left 설정하면된다.
			
		3.그리드 이동

		If GV1.FocusedColumn Is GV1.Columns("HBL_NO") Then
					If Trim(GV1.GetRowCellValue(GV1.FocusedRowHandle, "HBL_NO").ToString) = "" Then Exit Sub
					Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
					Dim fTarget As Object = frmMain.NavigateTo("AirHawbMgt")

					If fTarget IsNot Nothing Then
						fTarget.HBL_NO.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "HBL_NO")
						fTarget.SearchData()
					End If
				ElseIf GV1.FocusedColumn Is GV1.Columns("MBL_NO") Then
					If Trim(GV1.GetRowCellValue(GV1.FocusedRowHandle, "MBL_NO").ToString) = "" Then Exit Sub
					Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
					Dim fTarget As Object = frmMain.NavigateTo("AirMawbMgt")

					If fTarget IsNot Nothing Then
						fTarget.MBL_NO.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "MBL_NO")
						fTarget.SearchData()
					End If
				End If
				
		->포커스확인 ->타겟부모 설정 ->타겟설정 ->타겟화면에 데이터 집어넣기 ->타겟함수실행하기.

		4.Update나 Delete를 할때는 
		db.SqlSet(sql.Text)를 쓰는게 오류가없음
		이후 db.Commit()해줘야 실행완료됨

		5.case
												select Case dr("_INSFLAG")
								Case "I"
									
								Case "U"
									
								Case "D"
								   
								Case Else
									Continue For
							End Select
							
		6.그리드 클릭 이벤트 + 인터넷 url
		Private Sub GV1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GV1.DoubleClick
						If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim view As GridView = CType(sender, GridView)

				Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(pt)
				If GV1.FocusedRowHandle <> info.RowHandle Then '디버그할때 마우스 움직이면 Exit Sub로 빠져나감
					Exit Sub
				End If

				If GV1.FocusedColumn Is GV1.Columns("EVT_NM") Then ' 필드명, 다음줄도 필드명 
					System.Diagnostics.Process.Start("http://222.112.136.112/TPL_SCM/SHIPMENT/CUSTOMER_TRACING_SMEI_MAIN.asp?HBL_NO=" + Trim(GV1.GetRowCellValue(GV1.FocusedRowHandle, "HBL_NO").ToString) + "&HBL_TYPE=BL")
				End If
		End Sub
		02.01----------------------------------------------------------------------------------------------------------------------

		1.메세지박스(msgbox)
		biz-resultSet("TrxCode") = "N"
		biz-resultSet("TrxMsg") = "House B/L number is not found"
		moduls- dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
		moduls- MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)

		2.밴드 그리드(air-house B/L Management 화면 참조)
		밴드그리드쓰려면 Run Designer 위에 Click here to change view 를 눌러서 band모드로 바꿔줘야한다.
		이후 밴드추가하고 컬럼추가하고 밴드에 컬럼넣고 GV1속성에(OPTIONS-OPTIONVIEW) showcolumnHeaders를 false로 만들어주면 visual화면단에서 column값 안보임.
		실행화면단에서 안보이게하려면 WG1속성에 SaveLayout=False로 해야됨//아닌듯

		02.06----------------------------------------------------------------------------------------------------------------------
		 Dim dt As DataTable
		 dt = WG1.DataSource.Copy 수정 유무를 떠나서 그리드에 올라와있는 데이터 모두를 데이터테이블에 담는다.
		 
		02.07----------------------------------------------------------------------------------------------------------------------
		-여러창 띄우기
		 If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim view As GridView = CType(sender, GridView)

				Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(pt)
				If GV1.FocusedRowHandle <> info.RowHandle Then
					Exit Sub
				End If

				If GV1.FocusedColumn Is GV1.Columns("INFO") Then
					Dim myFirstForm As ExpHawbMgt
					myFirstForm = New ExpHawbMgt
					myFirstForm.HBL_NO.Text = Trim(GV1.GetRowCellValue(GV1.FocusedRowHandle, "HBL_NO").ToString)
					myFirstForm.SearchData()
					myFirstForm.Show()
				End If
				
		-탭드래그
		MainForm-xtraTabbedMdiManager1-FloatOnDrag=true !! 메인폼 탭 드래그해서 창빼내는 방법 설정

		Threading.Thread.Sleep(500) => ' 500 milliseconds = 0.5 seconds

		Private Sub xtraTabbedMdiManager1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles xtraTabbedMdiManager1.MouseMove
				If mouseDown Then
					If mouseMove = 1 Then
						Me.Location = New System.Drawing.Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
						'Me.Update()
					End If
				End If
			End Sub

			Private Sub xtraTabbedMdiManager1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles xtraTabbedMdiManager1.MouseDown
				mouseDown = True
				lastLocation = e.Location
				mouseMove = xtraTabbedMdiManager1.Pages.Count
			End Sub

			Private Sub xtraTabbedMdiManager1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles xtraTabbedMdiManager1.MouseUp
				mouseDown = False
			End Sub
			
		-폼 닫을때 물어보기 YES or NO
		1)If Me.ConfirmOnExit = False Then
					e.Cancel = False
				ElseIf Me.Visible AndAlso MsgBoxSC("Do you want to quit application?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
					e.Cancel = False
				Else
					e.Cancel = True
				End If
				
		-
		-------------------------------------------------------------SCM 파일설치경로 
		C:\Users\YJIT\AppData\Local\Apps\2.0\3QGK9QJ4.0AX\5CT8DHDA.RQZ
		or
		C:\Users\Administrator\AppData\Local\Apps\2.0\3QGK9QJ4.0AX\5CT8DHDA.RQZ

		파일명(yjit..tion_0000000000000000_0001.0000_f46a2bc2225934c9)

		C:\Users\Administrator\AppData\Local\Apps\2.0 통채로 날려보면 확인가능

		설치안되면 V3 보안끄고 설치해보기

		-------------------------------------------------------------elvis파일경로
		1)문서-yjit-~~ 
		2)프로그램제거

		iis 500 에러 
		CMD 작업관리자 시작
		c:\windows\system32\aspnet_regiis.exe -i 하면됨 - 지우고 새로깜

		2017-02-22 
		yes or no if문
						If MsgBoxSC(NumericTextBox3.Text + "개의 복사본을 만들겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
							'yes
				Else
				  'no
				End If

		Me.ActiveControl = TextBox7 - focus정할때 (포커스,FOCUS)

		!dev설치후 VisualStudio 실행안될경우 프로그램 제거에서 .net Framework 언어팩 지워주면됨

		콤보박스 리스트보이게 하기 (아래화살표 눌렀을때)
		 If e.KeyCode = Keys.Down Then
					ComboBox14.DroppedDown = True
				End If

		데이트박스 아무것도 입력받은게 없을경우 오늘날짜 넣어주기
		Private Sub DateBox2_Leave(sender As System.Object, e As System.EventArgs) Handles DateBox2.Leave
				If DateBox2.Text = "" Then
					S_DATE.Text = System.DateTime.Now.ToString("yyyyMMdd")
				End If
			End Sub
			
		코드박스 목록나오게 하려면 F11눌러야함 - Auto Suggestion

		콤보박스 데이터 옮기는건 임의의 변수에 index값을 담은후 폼 로드할때 불러와야함 - NewForm 만들때
		ex)form1.num = me.combobox1.selectedIndex 
		-----
		formload => form1.combobox1.selectedIndex=me.num

		날짜 단축키
		 If e.KeyCode = Keys.Up AndAlso e.Alt Then
					Year += 1
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				ElseIf e.KeyCode = Keys.Down AndAlso e.Alt Then
					Year -= 1
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				ElseIf e.KeyCode = Keys.Right AndAlso e.Alt Then
					Month += 1
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				ElseIf e.KeyCode = Keys.Left AndAlso e.Alt Then
					Month -= 1
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				ElseIf e.KeyCode = Keys.Right AndAlso e.Control Then
					day += 7
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				ElseIf e.KeyCode = Keys.Left AndAlso e.Control Then
					day -= 7
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				ElseIf e.KeyCode = Keys.Up AndAlso e.Control Then
					day += 1
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				ElseIf e.KeyCode = Keys.Down AndAlso e.Control Then
					day -= 1
					DateBox3.Text = System.DateTime.Now.AddYears(+Year).AddMonths(+Month).AddDays(+day).ToString("yyyyMMdd")
				End If

		Textbox.Multiline = True; 크기조절 TEXTBOX
		Label.AutoSize = False; 크기조절 LABEL


		***********************************************SplitContainterControl(창크기조절)************************************************************

		*창 사이즈조절하려면 dev 도구상자에 SplitContainterControl 을 쓰면된다 기존세팅 세로바 가로로 바꾸려면 Horizontal 수정하면됨
		안에들어가는자료 넣고 제일큰 splitControl만 anchor 상하좌우 설정하면 세팅끝

		***********************************************Textbox AutoComplete(자동완성)************************************************************

		autocomplete - 텍스트박스 자동완성기능  참조:ICSK-EXPSTOCKMGT

		*Textbox 기본설정: AutoCompleteMode = Suggest / AutoCompleteSource = CustomSource

		modul)-------------------------------------------------------------------------------------------------

		Private Sub Auto() 
				Dim params As DataSet = Me.ConvertToDataset()
				Dim dt As DataTable
				Dim dsRet As DataSet
				'////////WCF Service Call/////////
				Try
					dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ExpStockMgt", "AutoComplete", params) '서치해서 데이터담아옴
					dt = dsRet.Tables("Data.WG1")
					Dim str(dt.Rows.Count - 1) As String

					For index = 0 To dt.Rows.Count - 1
						str(index) = dt.Rows(index)("WH_NM")
					Next
					Dim instcol As AutoCompleteStringCollection = New AutoCompleteStringCollection()
					instcol.AddRange(str)
					Me.OFFICE_CD.AutoCompleteCustomSource = instcol 'OFFICE_CD 가 텍스트박스임
				Catch ex As Exception
					Exit Sub
				End Try
			End Sub
			
		biz)-------------------------------------------------------------------------------------------------
						Public Shared Function AutoComplete(ByVal ds As DataSet) As Dictionary(Of String, Object)
					Dim resDs As DataSet = New DataSet
					Dim resultSet As New Dictionary(Of String, Object)
					Dim drHeader As DataRow
					Dim dt As DataTable
					Dim db As DBA = New DBA()
					Dim sql As New SqlBox("ExpStockMgt@AutoComplete")

					drHeader = ds.Tables("MAIN").Rows(0)
					sql.Params("WH_NM") = drHeader("OFFICE_CD").ToString
					Try
						dt = db.SqlGet(sql.Text)
						dt.TableName = "WG1"
						resDs.Tables.Add(dt)

					Catch ex As Exception

					End Try
					
					resultSet("Status") = "SUCCESS"
					resultSet("Data") = resDs

					Return resultSet
				End Function
				
			// db= SELECT WH_NM FROM MDM_WH_MST - 서치부분(sql)
			
			******************************************************* Excel_Log *****************************************************

		대부분 팝업관련코드는 Yjit.SC.App/Common/PopupBase에 있다. 
		YJIT.SC.APP-COMMON-PopupBase 안에 엑셀은 ExcelExport()에 들어있다.

		--PopupBase.vb-ExcelExport()함수안에 
						If Datarow("TrxCode") = "Y" Then
					If MsgBoxSC("Do you want open this file?", MessageBoxButtons.YesNo, "Open", MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
						Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
						process.StartInfo.FileName = dlgSaveExcel.FileName
						process.StartInfo.Verb = "Open"
						process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
						process.Start()
					End If
				End If

						밑에 
						
				If Datarow("TrxCode") = "Y" Then
					Dim dsRet As DataSet = New DataSet
					dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ExcelLog", "Save", dsRet)
				End If
				
				라고 적어서 biz 콜하면됨 !!콜할때 biz로 만들어야됨 다른곳은 호출안됨
				
		--biz단
		/
		Imports Microsoft.VisualBasic
		Imports System.Data
		Imports System.Exception
		Imports System.Collections.Generic
		Imports YJIT.Data
		Imports YJIT.Biz.Common

		Namespace YJIT.Biz
			Public Class ExcelLog

				Public Sub Save(ByVal ds As DataSet)

					Dim resultSet As New Dictionary(Of String, Object)
					Dim db As DBA = New DBA()
					Dim retDs As DataSet = New DataSet
					Dim drHeader As DataRow
					Dim dt As DataTable
					Dim sql As SqlBox
					Dim ErrorOccur As Boolean = True
					Try
						db.BeginTransaction()
						sql = New SqlBox("ExcelLog@Save")


						'sql.Params("CTRY_CD") = dr("CTRY_CD").ToString

						db.SqlSet(sql.Text)
						db.Commit()
					Catch ex As Exception
						db.Rollback()
					Finally
						db.EndTransaction()
					End Try

				End Sub

			End Class

		End Namespace
		/
		이후 sql 생성해서 정보 저장시켜주면된다. ex) insert into ....


		************************************************Excel 드래그앤드랍***************************************************
		참고:ICSK->HblUpload

		1.grid 속성 AllowDrop=true

		2.Private Sub WG2_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles WG2.DragEnter
				e.Effect = DragDropEffects.Copy
			End Sub

		3.Dim data() As String = e.Data.GetData(DataFormats.FileDrop) 로 드래그한 파일 위치를 가지고온다.
		  Dim result As String = String.Join(".", data) 로 배열을 기존 문자열로 바꿔준다.
		  sExcelPath = result 그다음 기존 엑셀 처리하던 소스 넣어주면 완성
		  
		************************************************파일 저장***************************************************
		참고:ICSK->ComDocumentMgt

		D:\ICSK\WebApp\EDMS\DOC\ICSK.ELVIS.COM 경로에 저장된다
		DB는 COM_DOC_MST테이블에 저장된다.
		*추후에 더해봐야될듯.
		ex)/EDMS/DOC/ABC.ELVIS.COM/ABC/20170315/
		************************************Gridview Copy&Paste (그리드뷰 복사 붙여넣기)*********************************
		참고사이트:http://yjit.hanbiro.net/ngw/app/#/board/view/h0_22/0_26 (Copy and Paste)
		참고:ICSK->ExpTariffMgt

		파일다운로드
		COMDOC 에 DOWNLOADFILE 참조
		COM_DOC_MST BIZ단 COPY 참조

		*다운로드하는거 배포에서만 됨


		********************************* 체크박스 shift 드래그 선택 *********************************
		+전역변수로 Dim GridChk As String = "Y" 선언해주기

		Private Sub GV1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles GV1.MouseDown
				Dim view As GridView = TryCast(sender, GridView)
				Dim hi As GridHitInfo = view.CalcHitInfo(e.Location)
				If ModifierKeys = Keys.Shift AndAlso view.FocusedColumn Is GV1.Columns("CHK") AndAlso hi.Column Is GV1.Columns("CHK") Then
					Dim min As Integer = Math.Min(hi.RowHandle, view.FocusedRowHandle)
					Dim max As Integer = Math.Max(hi.RowHandle, view.FocusedRowHandle)
					For i As Integer = min To max - 1  ' 일반은 -1 멀티셀렉트 0
						view.SetRowCellValue(i, GV1.Columns("CHK"), GridChk)
					Next i
					If GridChk = "Y" Then
						GridChk = "N"
					Else
						GridChk = "Y"
					End If
				End If
			End Sub
			
		********************************* 체크박스 만들기  *********************************
		1)컬럼추가
		2)컬럼에디트-체크박스
		3)필드명 db랑 맞추기
		4)컬럼에디트 상세속성에서 TRUE 값과 FALSE 값을 Y,N으로 변경해야됨
		5)디스플레이 포멧 디스플레이포멧 체크,언체크 N,Y 설정하고 그래도안되면 껏다가 디버그모드로 키면됨 

		*********************************그리드뷰 체크박스 눌렀을때 그리드안에 데이터넣기*********************************
		참고:ICSK->MdmWarahouseMgt
				Private Sub GV1_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanging
				If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim view As GridView = CType(sender, GridView)

				Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(pt)
				If GV1.FocusedRowHandle <> info.RowHandle Then
					Exit Sub
				End If

				If GV1.FocusedColumn Is GV1.Columns("ABC") Then
					If GV1.GetRowCellValue(GV1.FocusedRowHandle, "WH_NM").ToString() <> "ABCD" Then '"ABCD"는 나중에 데이터불러오면 넣어야될값
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("WH_NM"), "ABCD") '(포커스핸들러,gv1.columns(필드명),넣을값)
					Else
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("WH_NM"), "")
					End If
				End If
			End Sub
			
		********************************* 달력 폼 만들기(date,monthcalendar)  *********************************
		참고:ABC->TmsList01List->DateForm.vb
		monthCalendar1.SelectionRange = new SelectionRange(Convert.ToDateTime("2017-04-01"), Convert.ToDateTime("2017-04-01"));  // String->DateTime
		 textBox1.Text = monthCalendar1.SelectionStart.ToString(); // Datetime->String
		 myFirstForm.S_DATE_FM.Text = MonthCalendar1.SelectionStart.ToString("yyyyMMdd")
		 myFirstForm.S_DATE_TO.Text = MonthCalendar1.SelectionEnd.ToString("yyyyMMdd")
		 
		 ********************************* 자식폼->부모폼 데이터 전송  *********************************
		 ++ 다른화면 폼 불러올때는 참조추가하면됨.
		 
		 
		 Me.CenterToParent()
		메인폼(TmsList01List) -> 자식폼(DateForm) 호출
		 Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
				Dim Newform As DateForm
				Newform = New DateForm
				Newform.Owner = Me
				Newform.Show()
		End Sub

		자식폼 작업끝내고 확인누를때
		Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
				Dim myFirstForm As TmsList01List
				myFirstForm = Me.Owner
				myFirstForm.S_DATE_FM.Text = MonthCalendar1.SelectionStart.ToString("yyyyMMdd")
				myFirstForm.S_DATE_TO.Text = MonthCalendar1.SelectionEnd.ToString("yyyyMMdd")
				Me.Close()
		End Sub

		********************************* 부모폼안에 자식폼 스크린 위치하게  *********************************
		Me.CenterToParent()

		********************************* Switch - case - example *********************************
		Select Case day
					Case "red"
						MsgBox("You selected red")
					Case "blue"
						MsgBox("You selected blue")
					Case "green"
						MsgBox("You selected green")
				End Select
				
		********************************* svn update  *********************************
		YJIT.SC.FMS.sln - 프로젝트 목차 추가됬을경우 올려야됨
		YJIT.SC.App->MainForm.Designer,resx,vb - 프로젝트 메인화면 바꼇을경우 해줘야됨 서버의경우 exe만 넘겨준다.
		파일 복사하면 modul,biz,sql 만들어주고 커밋

		********************************* DB값 텍스트박스에 뿌려주면됨  *********************************
		ClearView(UI.AppliedRangeTypes.Except, {WG1, CUST_NM, CUST_CLASS, GOODS, CUST_ATTN_CD, CUST_KEY_MAN_CD, CEO_VISIT, SPON_VISIT, SALES_VISIT, WORK_VISIT, TALK_CONTENT, REQ_CONTENT})

		********************************* 받는데이터 값이 빈값이 아닐때는 블럭해제  *********************************
		If drHeader("S_CUST_ATTN_CD").ToString <> "" Then sql.Blocks("CUST_BLOCK") = True
		[CUST_BLOCK] [/CUST_BLOCK]
		sql.Params("CUST_NM") = drHeader("S_CUST_NM").ToString & ""

		********************************* 그리드 좌측상단(왼쪽위) 글 없애기(grid)  *********************************
		GV1->Options->OptionsView->ShowViewCaption=false
		WG1->YJIT->SaveLayout = false

		밑단 보이려면 ShowFooter =False 로 변경하면됨.

		********************************* 그리드 체크박스 한번에 체크 안될때(grid checkBOX click)  ********************************* 일단사용하자
		Private Sub GV1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GV1.RowCellClick

				If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim view As GridView = CType(sender, GridView)
				Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(pt)
				If GV1.FocusedRowHandle <> info.RowHandle Then
					Exit Sub
				End If
				Dim a As String
				a = GV1.FocusedColumn Is GV1.Columns("COL_1")
				If GV1.FocusedColumn Is GV1.Columns("COL_1") Then
					If GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_1")) = "Y" Then
						'heck=N
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_1"), "N")
						'clear
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_6"), "")
					Else
						'Check=Y
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_1"), "Y")
						'insert
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_6"), Car_txt1.Text)
					End If
				End If
			End Sub

			Private Sub GV1_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanging
				If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim view As GridView = CType(sender, GridView)
				Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(pt)
				If GV1.FocusedRowHandle <> info.RowHandle Then
					Exit Sub
				End If
				Dim a As String
				a = GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_1"))
				If GV1.FocusedColumn Is GV1.Columns("COL_1") Then
					If GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_1")) = "Y" Then 'Y->N
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_1"), "N")
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_6"), "")
					Else 'N->Y
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_1"), "Y")
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("COL_6"), Car_txt1.Text)
					End If
				End If

			End Sub
			
		********************************* 그리드 수정안되게(readonly,allowedit)  *********************************
		readonly=true
		allowedit=false

		********************************* 콤보박스(combobox)  *********************************
		combo.text =  콤보박스 선택한 값 보이게
		combo.value = 인수값 보이게
		combo.selectedindex = 선택한 순번

		SHIPPING_LINE.SelectedIndex > 0 데이터 있을때만

		If CNE_TYPE.SelectedValue = "" Then 없을때만 데이터 넣어주기
					SVC_TYPE.SelectedValue = "01"       'Service Type
				End If

		********************************* 콤보박스(combobox)선택후 버튼클릭하면 그리드(grid)에 일괄적으로 데이터 집어넣기  *********************************
		Private Sub Type_btn_Click(sender As System.Object, e As System.EventArgs) Handles Type_btn.Click
				If Me.Visible AndAlso MsgBoxSC("배차유형 등록하시겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
					For i = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(i, "COL_1") = "Y" Then
							GV1.SetRowCellValue(i, GV1.Columns("COL_10"), Type_combo.Text)
						End If
					Next
				Else
					Exit Sub
				End If
			End Sub
			
		********************************* 그리드 clear 안될때  *********************************
		For index = 0 To GV1.RowCount
					GV1.DeleteRow(0)
				Next
				

		ClearView(UI.AppliedRangeTypes.Only, {WG1}) 이거 사용하면됨
				
		********************************* 그리드 커서 올렸을때 Cursor 변경되게(마우스)  *********************************
				Private Sub GV1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles GV1.MouseMove
				Dim hitInfo As GridHitInfo = GV1.CalcHitInfo(e.Location)
				If (hitInfo.InRowCell = True And hitInfo.Column Is GV1.Columns("COL_1")) Then
					Cursor = Cursors.Hand
				ElseIf (hitInfo.InRowCell = True And hitInfo.Column Is GV1.Columns("COL_2")) Then
					Cursor = Cursors.Hand
				ElseIf (hitInfo.InRowCell = True And hitInfo.Column Is GV1.Columns("COL_3")) Then
					Cursor = Cursors.Hand
				Else
					Cursor = Cursors.Default
				End If
			End Sub
				
				
		********************************* Newform 새로운폼에 데이터옮기기 (폼 복사,복제)  *********************************
						
						Dim LoadDataset As DataSet - 전역변수
						
						--- Formload() --- 'dataset 받아와서 바인딩 시키기
						If LoadDataset IsNot Nothing Then
					Me.BindToDataset(LoadDataset, "Data")
				End If
				
				--- Newform() --- 'New button (버튼클릭 이벤트 함수)
				Dim myFirstForm As TmsAloc02Mgt
				myFirstForm = New TmsAloc02Mgt
				
				For i = 0 To GV1.RowCount - 1 '그리드에 있는 내용 통채로 옮기려면 사용하고 수정된것만 옮기려면 코드 빼도상관없음)
					If GV1.GetDataRow(i).RowState = DataRowState.Unchanged Then
						GV1.GetDataRow(i).SetModified()
					End If
				Next

				myFirstForm.LoadDataset = ConvertToDataset() '-현재의값 데이터셋에 담기'
				myFirstForm.LoadDataset.Tables("Main").TableName = "Data.Main" '테이블명 변환'
				myFirstForm.LoadDataset.Tables("WG1").TableName = "Data.WG1" '테이블명 변환'
				myFirstForm.Show()
				
				다른폼 데이터 받으려면
				변수 앞에 PUBLIC 붙여주면됨
				
				
		********************************* 디버깅 속도 설정 ***********************************

		도구->옵션->프로젝트 및 솔루션->빌드 및 실행->실행할 때 시작 프로젝트와 종속성만 빌드 체크

		********************************* 메시지박스 앞에 문자열 Data not found 들어가면 메시지박스 사라짐 ***********************************

		MsgBoxLocalized("Data not found 선택해주세요.", MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)

		********************************* 데이터테이블(data table 수정변경)-데이터셋 병합  ***********************************
							  Dim ds As DataSet
					ds = ConvertToDataset()
				   ------------------------

		Dim dt As DataTable = WG1.DataSource.copy
					dt.TableName = "WG1"
					ds.Merge(dt)

		********************************* 콤보박스 데이터 들어온거 다시정리 ***********************************

		Dim dt As DataTable
				dt = SO_MODE.DataSource
				For index = 0 To dt.Rows.Count - 1
					If dt.Rows(index)("CODE") = "GNA" Or dt.Rows(index)("CODE") = "GNL" Then
						Continue For
					Else
						dt.Rows(index).Delete()
					End If
				Next
				SO_MODE.DataSource = dt
				
		**콤보박스에 COMBOBOX에 db값 집어넣기 ABC-ALOC07MGT 참조
		받는파라메터가 NAME,CODE 로 되어있으니깐 테이블 컬럼도 NAME,CODE로 맞춰서 
		콤보박스.DataSource = 데이터테이블 하면됨
				
				
		********************************* 코드박스 같이 지워지게  ***********************************
		KeepIntegrity=True

		********************************* 공통코드   ***********************************
		메뉴는 관리-공통코드
		moduls)MdmCommonMgt
		biz)YJIT.CodeService - CommonCode
		sql)MDM_COM_CODE
		*조건부로 일부만 가지고 오려면 ITEM 을 이용하면된다. 파라미터를 추가하면된다.(item에 항목도 추가하고)



		********************************* 특정문자열 자르기 ***********************************
		Dim a As String = LISENCE_NO.Text
					Dim Carstr As String = a.Substring(a.Length() - 4)
					If IsNumeric(Carstr) Then '숫자면 True 아니면 False
						CAR_NO.Text = Carstr
					Else
						MsgBox("차량등록번호를 정확히 입력하세요.")
						Exit Sub
					End If
					
					시작지점,도착지점
					
					If S_DATE_FM.Text.Substring(0, 4) <> S_DATE_TO.Text.Substring(0, 4) Then
					MsgBoxLocalized("기준일자를 같은년도로 선택해야됩니다.")
					Exit Sub
				End If
					
		********************************* 해당탭에서 기능안되게 메시지박스 띄우기 ***********************************
		If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then         ' Order 조회 부분
					MsgBox("조회 화면에서 삭제가 안됩니다!")
					Exit Sub
					
		********************************* 해당그리드 손가락 ***********************************
					 Private Sub GV1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles GV1.MouseMove
				Dim hitInfo As GridHitInfo = GV1.CalcHitInfo(e.Location)
				If (hitInfo.InRowCell = True And hitInfo.Column Is GV1.Columns("COL_1")) Then
					Cursor = Cursors.Hand
				ElseIf (hitInfo.InRowCell = True And hitInfo.Column Is GV1.Columns("COL_2")) Then
					Cursor = Cursors.Hand
				ElseIf (hitInfo.InRowCell = True And hitInfo.Column Is GV1.Columns("COL_3")) Then
					Cursor = Cursors.Hand
				Else
					Cursor = Cursors.Default
				End If
			End Sub
			
		********************************* 그리드 체크박스 눌렀을때 데이터 그리드에 들어가게하기 ***********************************
		If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim view As GridView = CType(sender, GridView)
				Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(pt)
				If GV1.FocusedRowHandle <> info.RowHandle Then
					Exit Sub
				End If
				If GV1.FocusedColumn Is GV1.Columns("CHK") Then
					If GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("CHK")) = "Y" Then 'Y->N
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("CHK"), "N")
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("CAR_NO"), "")
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("TRAN_NM"), "")
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("CAR_TEL"), "")
					Else 'N->Y
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("CHK"), "Y")
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("CAR_NO"), Car_txt1.Text) 'IO_TYPE
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("TRAN_NM"), Car_txt3.Text)
						GV1.SetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("CAR_TEL"), Car_txt5.Text)
					End If
				End If

		** 데이터가 안들어갈 경우 쿼리에서 빈값이라도 받아와야됨(Search)

		********************************* 데이터테이블 컬럼추가후 병합(합치기)Merge ***********************************
		 Dim dt As DataTable = New DataTable
		 Dim dt1 As DataTable = New DataTable
		 dt.Columns.Add("CUST_NM")
		 dt.Columns.Add("CUST_CD")
		 Dim workRow As DataRow = dt.NewRow()
		 workRow("CUST_NM") = "--선택--"
		 workRow("CUST_CD") = "0"
		 dt.Rows.Add(workRow)
		 dt1 = db.SqlGet(sql.Text, False)
		 dt.Merge(dt1)
		 
		 ********************************* Check ComboBox ***********************************
		 DevExpress.XtraEditors.CheckedComboBoxEdit 사용
		 
		 Public Sub GridInit()

				SetMandatoryLine(Me)

				Dim searchParams As Dictionary(Of String, Object)
				Dim dataParams As Dictionary(Of String, Object)
				Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit

				' Office Lookup : S_OFFICE_CD
				Dim bindingSourceProduct = New BindingSource()
				searchParams = New Dictionary(Of String, Object)
				dataParams = New Dictionary(Of String, Object)
				dataParams.Add("GroupCode", "T03")
				dataParams.Add("NameType", "")
				'dataParams.Add("Item3", "")

				bindingSourceProduct.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
				If bindingSourceProduct.Count <> 0 Then
					SO_MODE.Properties.DataSource = bindingSourceProduct.DataSource
					SO_MODE.Properties.ValueMember = "CODE"
					SO_MODE.Properties.DisplayMember = "NAME"
					SO_MODE.Properties.NullText = String.Empty
					SO_MODE.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
					SO_MODE.Properties.SeparatorChar = ";"
					SO_MODE.CheckAll()
					'SO_MODE.SetEditValue("FCL")
				End If

			End Sub
			
			
		 ********************************* 그리드 체크박스 체크안될때(한번에 안될때) ***********************************
		 GV1->OPTION->OptionsBehavior->EditorShowMode->Default
		 
		 ********************************* 그리드 헤더체크박스 SelectALL ***********************************
		 Dim selectAll As YJIT.SC.UI.GridCheckMarksSelection
				selectAll = New YJIT.SC.UI.GridCheckMarksSelection(GV1)
				selectAll.CheckMarkColumn.VisibleIndex = 0
				selectAll.CheckMarkColumn.FieldName = "ALL_CHK"
				selectAll.CheckMarkColumn.Caption = " "
				selectAll.CheckMarkColumn.Width = 30
				GV1.Columns("ALL_CHK").OptionsColumn.AllowSort = False
				
		체크올 쓸경우에는 DATASET에 데이터가 없기때문에
				
		********************************* 그리드 컬럼 옮긴것 저장되게  ***********************************
		wg1-yjit-savelaout = true // 그리드 컬럼 안옮겨질때 GV1-AllowColumnMoving = true

		*var 타입 dim a as VariantType

		쿼리 IN 받을때
		BIZ) sql.AllowSqlInjection = True ' in 사용시 option 추가하고
			 sql.Params("SO_MODE") = drHeader("SO_MODE").ToString.Replace(" ", "").Replace(";", "','")
			 
		BI)  biz단 바로 빠져나가기 ThrowMsg(ErrorOccur, "Invoice is closed!") 에러메세지

		********************************* 그리드 체크박스  ***********************************
		For index = 0 To dt.Rows.Count - 2 '매입 체크---------------------------------------------------------------------------------------------
							If dt.Rows(index)("CHK") = "Y" Then
								So_Group += dt.Rows(index)("SO_NO") + "; "
							End If
						Next
						If dt.Rows(dt.Rows.Count - 1)("CHK") = "Y" Then
							So_Group += dt.Rows(dt.Rows.Count - 1)("SO_NO")
						End If

						sql = New SqlBox("TmsAloc02Mgt@InvoiceCheck")
						sql.AllowSqlInjection = True ' in 사용시 option 추가하고
						sql.Params("SO_MODE") = So_Group.Replace(" ", "").Replace(";", "','")
						dt1 = db.SqlGet(sql.Text)
						If dt1.Rows.Count = 0 Then
							ThrowMsg(ErrorOccur, "운임정보가 없습니다.")
						End If
						
		********************************* 그리드 로우,셀 ROW,CELL 별로 READONLY ALLOWEDIT 적용하기  ***********************************
				Private Sub GV1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
				Call SetCustAllowEdit(GV1)
			End Sub

			Private Sub SetCustAllowEdit(ByVal Grid As DevExpress.XtraGrid.Views.Grid.GridView)
				Try
					If GV1.GetRowCellValue(Grid.FocusedRowHandle, "INV_NO").ToString <> "" Then
						GV1.Columns("LOAD_ST_HM").OptionsColumn.AllowEdit = True
						GV1.Columns("LOAD_ST_HM").OptionsColumn.ReadOnly = False
						GV1.Columns("ARR_PLAN_HM").OptionsColumn.AllowEdit = True
						GV1.Columns("ARR_PLAN_HM").OptionsColumn.ReadOnly = False
						GV1.Columns("LOAD_PLAN_HM").OptionsColumn.AllowEdit = True
						GV1.Columns("LOAD_PLAN_HM").OptionsColumn.ReadOnly = False
						GV1.Columns("LOAD_HM").OptionsColumn.AllowEdit = True
						GV1.Columns("LOAD_HM").OptionsColumn.ReadOnly = False
						GV1.Columns("UNLOAD_PLAN_HM").OptionsColumn.AllowEdit = True
						GV1.Columns("UNLOAD_PLAN_HM").OptionsColumn.ReadOnly = False
						GV1.Columns("UNLOAD_HM").OptionsColumn.AllowEdit = True
						GV1.Columns("UNLOAD_HM").OptionsColumn.ReadOnly = False
						GV1.Columns("ARR_RPT_HM").OptionsColumn.AllowEdit = True
						GV1.Columns("ARR_RPT_HM").OptionsColumn.ReadOnly = False
					Else
						GV1.Columns("LOAD_ST_HM").OptionsColumn.AllowEdit = False
						GV1.Columns("LOAD_ST_HM").OptionsColumn.ReadOnly = True
						GV1.Columns("ARR_PLAN_HM").OptionsColumn.AllowEdit = False
						GV1.Columns("ARR_PLAN_HM").OptionsColumn.ReadOnly = True
						GV1.Columns("LOAD_PLAN_HM").OptionsColumn.AllowEdit = False
						GV1.Columns("LOAD_PLAN_HM").OptionsColumn.ReadOnly = True
						GV1.Columns("LOAD_HM").OptionsColumn.AllowEdit = False
						GV1.Columns("LOAD_HM").OptionsColumn.ReadOnly = True
						GV1.Columns("UNLOAD_PLAN_HM").OptionsColumn.AllowEdit = False
						GV1.Columns("UNLOAD_PLAN_HM").OptionsColumn.ReadOnly = True
						GV1.Columns("UNLOAD_HM").OptionsColumn.AllowEdit = False
						GV1.Columns("UNLOAD_HM").OptionsColumn.ReadOnly = True
						GV1.Columns("ARR_RPT_HM").OptionsColumn.AllowEdit = False
						GV1.Columns("ARR_RPT_HM").OptionsColumn.ReadOnly = True
					End If
				Catch
					Exit Sub
				End Try
			End Sub
			
		********************************* 데이터테이블 컬럼,Column 조건확인해서 컬럼이름 label 변환해서 넣기  ***********************************
			
			 Dim ds As DataSet
				ds = Me.ConvertToDataset
				Dim dt As DataTable
				dt = ds.Tables("MAIN")
				For index = 0 To dt.Columns.Count - 1
					If dt.Rows(0)(index).ToString() = "N" Then
						DirectCast(Me.Controls.Find(dt.Columns(index).ColumnName, True)(0), Label).ForeColor = Color.Red
					Else
						DirectCast(Me.Controls.Find(dt.Columns(index).ColumnName, True)(0), Label).ForeColor = Color.Black
					End If
				Next

		********************************* 디자이너 변경할때  ***********************************

		System.Windows.Forms.TextBox -> YJIT.SC.UI.SCControls.TextBox


		********************************* 그리드 로우 글자색상 바꾸기  ***********************************
		'Row의 글자색깔을 결정한다
			Private Sub GV1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV1.RowStyle
				If GV1 Is Nothing Then Exit Sub
				If GV1.RowCount = 0 Then Exit Sub
				If e.RowHandle < 0 Then Exit Sub
				If GV1.GetRowCellValue(e.RowHandle, "SO_CHK").ToString = "N" Then
					e.Appearance.ForeColor = Color.Red
				End If



				'If GV1 Is Nothing Then Exit Sub
				'If GV1.RowCount = 0 Then Exit Sub
				'If e.RowHandle < 0 Then Exit Sub

				''그리드 행, 컬럼에 해당 색을 표시함
				'If GV1.GetRowCellValue(e.RowHandle, "REQ_SVC").ToString = "01" Then     '등록대기
				'    e.Appearance.ForeColor = Color.Red   '해당 Row 배경을 Red FF0000(255,0,0)으로 바꿈
				'ElseIf GV1.GetRowCellValue(e.RowHandle, "REQ_SVC").ToString = "04" Then '오더보류
				'    e.Appearance.ForeColor = Color.Purple   '해당 Row 배경을 보라색 330066(51,0,102)으로 바꿈
				'ElseIf GV1.GetRowCellValue(e.RowHandle, "REQ_SVC").ToString = "05" Then '오더복구
				'    e.Appearance.ForeColor = Color.DarkBlue '해당 Row 배경을 감색 333366(51,51,102)으로 바꿈
				'Else        '그이외
				'    e.Appearance.ForeColor = Color.DarkBlue '해당 Row 배경을 감색 333366(51,51,102)으로 바꿈
				'End If


			End Sub

			'사이즈 Cell의 글자색깔을 결정한다
			Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
				If GV1 Is Nothing Then Exit Sub
				If e.Column.FieldName <> "DIM" Then Exit Sub

				If GV1.GetRowCellValue(e.RowHandle, "SO_CHK").ToString = "N" Then
					e.Appearance.ForeColor = Color.Red
				End If

				'If GV1 Is Nothing Then Exit Sub
				'If e.Column.FieldName <> "DIM" Then Exit Sub

				''그리드 행, 컬럼에 해당 색을 표시함
				'If GV1.GetRowCellValue(e.RowHandle, "REQ_SVC").ToString = "01" Then     '등록대기
				'    If GV1.GetRowCellValue(e.RowHandle, "ALOC_TYPE").ToString = "02" Then     '집하배차
				'        e.Appearance.ForeColor = Color.Orange   '해당 컬럼 배경을 Orange ff3300(255,51,0)으로 바꿈
				'    Else
				'        e.Appearance.ForeColor = Color.Red  '해당 컬럼 배경을 Red FF0000(255,0,0)으로 바꿈
				'    End If
				'Else        '그이외
				'    If GV1.GetRowCellValue(e.RowHandle, "ALOC_TYPE").ToString = "02" Then     '집하배차
				'        e.Appearance.ForeColor = Color.Orange   '해당 컬럼 배경을 Orange ff3300(255,51,0)으로 바꿈
				'    Else
				'        e.Appearance.ForeColor = Color.DarkBlue '해당 컬럼 배경을 감색 333366(51,51,102)으로 바꿈
				'    End If
				'End If
			End Sub
			
			
		********************************* 팝업 addrow 그리드 포커스FOCUS  ***********************************
			 FWG1_Popup.PopUpInit(Me, FWG1, "CUST_CD", "FARE_VAT_AMT")
			 
		********************************* 그리드 포커스 변경  ***********************************
			GV1.FocusedRowHandle = 4
			
		********************************* 폼 이벤트 생성하기  ***********************************
		 Private Sub Car_Btn_Click(sender As System.Object, e As System.EventArgs) Handles ALOC_CAR_SELECT.Click
				Dim Newform As TmsCarForm
				Newform = New TmsCarForm
				Newform.Owner = Me
				AddHandler Newform.FormClosed, AddressOf Newform_FormClosed
				Newform.Show()
			End Sub

			Private Sub Newform_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
				MsgBox("asdfasdfasdf")
			End Sub
			
			----------메모----------
			 Private Sub Button_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click
				Select Case DirectCast(sender, Button).Name //YJIT BUTTON일경 Button->YJIT.SC.UI.SCControls.Button
					Case "Button1"
						button1_Click(Me, New EventArgs())
					Case "Button2"

					Case "Button3"

					Case "Button4"

				End Select

			End Sub

			Private Sub button1_Click(sender As System.Object, e As System.EventArgs)
				MsgBox("asdf")
			End Sub
			
		********************************* 새 창 Navigate  ***********************************
		If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
				Dim fTarget As Object = Nothing
				Dim view As GridView = CType(sender, GridView)

				Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(pt)

				If GV1.FocusedRowHandle <> info.RowHandle Then
					Exit Sub
				End If

				'If Trim(GV1.GetRowCellValue(GV1.FocusedRowHandle, "HBL_NO").ToString) = "" Then Exit Sub

				Select Case GV1.GetRowCellValue(GV1.FocusedRowHandle, "SO_MODE")
					Case "AIR"
						fTarget = frmMain.NavigateTo("TmsOrd01Mgt", NavigatedWindowModes.Dialog, False)
					Case "LCL"
						fTarget = frmMain.NavigateTo("TmsOrd06Mgt", NavigatedWindowModes.Dialog, False)
					Case "FCL"
						fTarget = frmMain.NavigateTo("TmsOrd07Mgt", NavigatedWindowModes.Dialog, False)
					Case "GNA"
						fTarget = frmMain.NavigateTo("TmsOrd08Mgt", NavigatedWindowModes.Dialog, False)
					Case "GNL"
						fTarget = frmMain.NavigateTo("TmsOrd08Mgt", NavigatedWindowModes.Dialog, False)
					Case "GDS"
						fTarget = frmMain.NavigateTo("TmsOrd09Mgt", NavigatedWindowModes.Dialog, False)
					Case "SDS"
						fTarget = frmMain.NavigateTo("TmsOrd09Mgt", NavigatedWindowModes.Dialog, False)
					Case "PKG"
						fTarget = frmMain.NavigateTo("TmsOrd10Mgt", NavigatedWindowModes.Dialog, False)
						'Case "CHQ"Z
				End Select
				fTarget.SO_NO.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "SO_NO")
				fTarget.SearchData()
				fTarget.Show()
				
				
		********************************* 문자열자르기  ***********************************
				sql.Params("CAR_NO") = Left(drHeader("CAR_NO").ToString(), 4)
						sql.Params("CAR_DATE") = Right(drHeader("S_DATE_FM").ToString(), 8)
						
						Len

		 (문자열) 
		 문자열의 길이

		Len("abcdef" ) => 6

		Left

		 (문자열, 크기)
		왼쪽부터 크기만큼 추출

		Left ("abcdef" , 2 ) => ab

		Mid

		 (문자열,추출할 시작위치,크기)
		추출할 위치로부터 크기만큼 중간 문자를 추출

		Mid ("abcdef" , 3, 2) => cd

		출처: http://simmys.tistory.com/entry/VB-함수모음 [심스의 지식공간]
		********************************* gv1  ***********************************
						그리드 셀 병합(merge) -> gv1-option-optionview-AllowCellMerge =true
					   
		********************************* 데이터 Summary 따로 데이터가지고와서 붙여넣기  *********************************** 
		*showfooter는 true 하고 기본으로 설정해놔야함
					   Dim dr1 As DataRow
					dr1 = ds.Tables("Data.WG1_Sum").Rows(0)
					'GV1.Columns("MM").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, dr1("AIR_PER").ToString())
					
		참조:
		Private Sub Summary()

				Dim Selling As Integer = 0
				Dim Buying As Integer = 0

				For index = 0 To FGV2.RowCount - 1

					If FGV2.GetRowCellValue(index, "SELL_BUY_TYPE").ToString() = "S" Then '매출
						Selling += FGV2.GetRowCellValue(index, "FARE_LOC_AMT")
					Else '매입
						Buying += FGV2.GetRowCellValue(index, "FARE_LOC_AMT")
					End If

				Next

				FGV2.Columns("FARE_LOC_AMT").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, "매출 : " + String.Format("{0:###,###,###,###,###,##0}", Selling))
				FGV2.Columns("FARE_VAT_AMT").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, "매입 : " + String.Format("{0:###,###,###,###,###,##0}", Buying))
				FGV2.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
				FGV2.Appearance.FooterPanel.Options.UseTextOptions = True
			End Sub            
				 
		********************************* 체크박스 모두체크 selectall x checkall o  *********************************** 
					S_ITEM_CD.CheckAll()
					
		********************************* 숫자형 포맷(format)  *********************************** 
				   참조:https://msdn.microsoft.com/en-us/library/xfta99yt(v=vs.90).aspx
					'Dim a As Integer = dr1("AIR_COUNT")
					'Dim aa As String = FormatNumber(a, 2, , , TriState.True)
					
				  *SALES_GOAL_LBL.Text = FormatNumber("66944021", 0, , , TriState.True) /0적힌 부분이 소숫점 나타낼부분
					
		********************************* 코드박스-팝업 만들기  ***********************************
		1.CODEBOX - SearchPopup = 팝업띄울 UI 주로 Modules-FmsPopUp 안에있음 (구조는 따로 건들거 없고 건든다면 그리드 필드 맵핑정도)
		2.CODEBOX - CodeType = 팝업에서 서치할 데이터 (Yjit-CodeService- 안에 있음) 

							  Dim sql As SqlBox = Nothing
					sql = New SqlBox("CodeService@CarSearch")

		biz)
					If searchParams("SearchKey").ToString.Replace(";", " ") <> "" Then
						sql.Blocks("CAR_NO") = True
						sql.Params("CAR_NO") = searchParams("SearchKey").ToString.Replace(";", " ")
					End If
					
					---------------------------------
		biz)
					 Dim sql As SqlBox = Nothing
					sql = New SqlBox("CodeService@CarSearch")
					sql.Blocks("CAR_NO") = True
					sql.Params("CAR_NO") = validateKeys("KEY")
				 
					---------------------------------
		sql)   
		SELECT A.CAR_NO as CODE,A.CUR_DRV_NM as NAME,A.CUST_CD,B.CUST_NM 
		  FROM TMS_CAR_MST A , MDM_CUST_MST B
		WHERE A.CUST_CD=B.CUST_CD(+) 
			[CAR_NO]
			AND A.CAR_NO='@CAR_NO'
			[/CAR_NO]
			
		********************************* 그리드에 데이터 입력 안될때  ***********************************
		1.서치할때 매핑된 필드에 데이터 빈값이라도 들어와야 데이터 입력됨.

		******************************** 반올림  ***********************************
		Math.Round(value, 2)) 반올림
		MATH.Ceiling(value) 올림
		Math.Truncate(value) 버림

		**********************************  DataTable Sort / 데이터테이블 정렬 ******************************************
		dt.DefaultView.Sort = "CUSTOM_CAR_NO ASC"
		dt = dt.DefaultView.ToTable(True) '이거 넣어야 소팅됨'
				
		**********************************  grid checkbox 그리드 체크박스  ******************************************
		changing() 중 focus 이동하면 check가 안된다.

		**********************************  codebox 코드박스 열기  ******************************************
		CUSTOM_CD.Focus()
		CUSTOM_CD.Text = "1234"
		SendKeys.Send("{ENTER}")

		**********************************  Report Designer  ******************************************
		A4 가로 세로 설정하기 꼭대기속성-Page Setting-Landscape-no


		For index = 0 To ds.Tables("WG2").Rows.Count - 1
							SONO = SONO + ds.Tables("WG2").Rows(index)("SO_NO").ToString() + ";"
						Next
						
						sql.AllowSqlInjection = True
						sql.Params("SO_NO") = SONO.Replace(" ", "").Replace(";", "','")
						
						
		**********************************  그리드 헤더 클릭했을시 이벤트(일반) ******************************************
		 Private Sub GV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.Click
				If GV1.RowCount = 0 Then
					Exit Sub
				End If

				Dim p As Point = GV1.GridControl.PointToClient(MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(p)

				Dim time As String = System.DateTime.Now.ToString("HHMM")
				
				' "yyyyMMddHHmmss" - 24시간 연월일시분초
				' "yyyyMMddhhmmss tt" - am,pm 12시간 연월일시분초

				If info.InRowCell = False And info.Band.Caption = "상차출발" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("LOAD_ST_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Band.Caption = "픽업예정" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("ARR_PLAN_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Band.Caption = "픽업도착" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("LOAD_PLAN_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Band.Caption = "픽업완료" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("LOAD_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Band.Caption = "하차도착" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("UNLOAD_PLAN_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Band.Caption = "하차완료" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("UNLOAD_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Band.Caption = "도착보고" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("ARR_RPT_HM"), time)
						End If
					Next
				End If
			End Sub
			
		**********************************  그리드 헤더 클릭했을시 이벤트(밴드) ******************************************
			Private Sub GV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.Click
				If GV1.RowCount = 0 Then
					Exit Sub
				End If
				Dim p As Point = GV1.GridControl.PointToClient(MousePosition)
				Dim info As GridHitInfo = GV1.CalcHitInfo(p)

				Dim time As String = System.DateTime.Now.ToString("HHMM")

				If info.InRowCell = False And info.Column.Caption = "상차출발" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("LOAD_ST_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Column.Caption = "픽업예정" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("ARR_PLAN_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Column.Caption = "픽업도착" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("LOAD_PLAN_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Column.Caption = "픽업완료" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("LOAD_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Column.Caption = "하차도착" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("UNLOAD_PLAN_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Column.Caption = "하차완료" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("UNLOAD_HM"), time)
						End If
					Next
				ElseIf info.InRowCell = False And info.Column.Caption = "도착보고" Then
					For index = 0 To GV1.RowCount - 1
						If GV1.GetRowCellValue(index, "INV_NO").ToString() <> "" Then
							GV1.SetRowCellValue(index, GV1.Columns("ARR_RPT_HM"), time)
						End If
					Next
				End If
			End Sub
			
		**********************************  이벤트 통합 ******************************************
			Dim ctrlName As String = DirectCast(sender, TextBox).Name - 호출되는 컨트롤 이름 가져오기
			
		#참조#
		Private Sub Rmk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACT_SHIP_NM.TextChanged, BILL_NM.TextChanged, SHIP_NM.TextChanged, LOAD_NM.TextChanged
				'Biz 호출
				Dim ctrlName As String = DirectCast(sender, TextBox).Name
				Call SearchRmk(ctrlName)

			End Sub

			Public Sub SearchRmk(ByVal ctrlName As String)

				Dim ds As DataSet = ConvertToDataset()
				ds.Tables("MAIN").Columns.Add("CUST_RMK")
				ds.Tables("MAIN").Rows(0)("CUST_RMK") = ctrlName

				Try
					ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.TmsOrd01Mgt", "SearchRmk", ds)

					ds.Tables("data.MAIN").TableName = "REMARK"
					Select Case ctrlName
						Case "ACT_SHIP_NM"
							ACT_SHIP_TXT.Text = ds.Tables("REMARK").Rows(0)("TASK_SPECIAL")
						Case "BILL_NM"
							BILL_TXT.Text = ds.Tables("REMARK").Rows(0)("TASK_SPECIAL")
						Case "SHIP_NM"
							SHIP_TXT.Text = ds.Tables("REMARK").Rows(0)("TASK_SPECIAL")
						Case "LOAD_NM"
							LOAD_TXT.Text = ds.Tables("REMARK").Rows(0)("TASK_SPECIAL")
					End Select
				Catch ex As Exception
					'MsgBoxLocalized(ex.Message)
					Exit Sub
				End Try
				
			End Sub
			Public Shared Function SearchRmk(ByVal ds As DataSet) As Dictionary(Of String, Object)

					Dim ResultSet As New Dictionary(Of String, Object)
					Dim ResultDs As DataSet = New DataSet
					Dim db As DBA = New DBA()
					Dim drHeader As DataRow
					Dim sql As SqlBox
					Dim dt As DataTable
					Dim ErrorOccur As Boolean = True

					Try

						If Not ds.Tables.Contains("MAIN") Then
							ThrowMsg(ErrorOccur, "Data info missing.")
						End If

						drHeader = ds.Tables("MAIN").Rows(0)

						sql = New SqlBox("TmsOrd01Mgt@SearchRmk")
						Select Case drHeader("CUST_RMK").ToString
							Case "ACT_SHIP_NM"
								sql.Params("CUST_CD") = drHeader("ACT_SHIP_CD").ToString & ""
							Case "BILL_NM"
								sql.Params("CUST_CD") = drHeader("BILL_CD").ToString & ""
							Case "SHIP_NM"
								sql.Params("CUST_CD") = drHeader("SHIP_CD").ToString & ""
							Case "LOAD_NM"
								sql.Params("CUST_CD") = drHeader("LOAD_CD").ToString & ""
						End Select
						dt = db.SqlGet(sql.Text, False)
						dt.TableName = "MAIN"
						ResultDs.Tables.Add(dt)

						ResultSet("TrxCode") = "Y"
						ResultSet("TrxMsg") = "Success"
						ResultSet("Data") = ResultDs

					Catch ex As Exception
						If ErrorOccur Then
							ResultSet("TrxCode") = "E"
						Else
							ResultSet("TrxCode") = "N"
						End If
						ResultSet("TrxMsg") = ex.Message
					End Try

					Return ResultSet

				End Function

		**********************************파일실행******************************************

		System.Diagnostics.Process.Start("c:\\test.txt")
		System.Diagnostics.Process.Start("www.naver.com")


		**********************************월초월말 DateTime******************************************

		Dim startYMD As DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
		string fYMD = startYMD .ToString("yyyyMMdd")
		string lYMD = startYMD .AddMonths(1).AddDays(-1).ToString("yyyyMMdd")

		**********************************Dev 그래프(Graph) 대시보드 설정******************************************
		Dev - ChartControl

				'ChartControl1.Series.Item(0).Points.Add(New SeriesPoint("A", 15))
				
				Dim startYMD As DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
				Dim diagram As XYDiagram = TryCast(ChartControl1.Diagram, XYDiagram)
				diagram.AxisX.CustomLabels.Item(0).Name = "A"
				diagram.AxisX.CustomLabels.Item(0).Name = startYMD.ToString("MM") + ".01"
				
		참조:
		'ChartControl1.Series.Add("series3")
				'ChartControl1.Series("Series2").ChartType = SeriesChartType.Column
				'ChartControl1.Series("Series2").Points.AddY(20)
				'ChartControl1.Series("Series2").ChartArea = "ChartArea1"

				'Dim sideBySideBarChart As New ChartControl()

				'' Create the first side-by-side bar series and add points to it.
				'Dim series1 As New Series("Side-by-Side Bar Series 1", ViewType.Line)
				'series1.Points.Add(New SeriesPoint("A", 10))
				'series1.Points.Add(New SeriesPoint("B", 12))
				'series1.Points.Add(New SeriesPoint("C", 14))
				'series1.Points.Add(New SeriesPoint("D", 17))

				'' Create the second side-by-side bar series and add points to it.
				'Dim series2 As New Series("Side-by-Side Bar Series 2", ViewType.Bar)
				'series2.Points.Add(New SeriesPoint("A", 15))
				'series2.Points.Add(New SeriesPoint("B", 18))
				'series2.Points.Add(New SeriesPoint("C", 25))
				'series2.Points.Add(New SeriesPoint("D", 33))

				'' Add the series to the chart.
				'ChartControl1.Series.Add(series1)
				'ChartControl2.Series.Add(series2)

				'' Hide the legend (if necessary).
				''sideBySideBarChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

				'' Rotate the diagram (if necessary).
				'CType(sideBySideBarChart.Diagram, XYDiagram).Rotated = True

				'' Add a title to the chart (if necessary).
				'Dim chartTitle1 As New ChartTitle()
				'chartTitle1.Text = "Side-by-Side Bar Chart"
				'sideBySideBarChart.Titles.Add(chartTitle1)

				'' Add the chart to the form.
				'sideBySideBarChart.Dock = DockStyle.Fill
				'Me.Controls.Add(ChartControl1)
				
				
				
				
		*********************************YJIT 날짜 콤보박스(Date combobox)******************************************* 
				Dim T_CUR_YEAR As String
				Dim T_YEAR As Integer
				Dim ds As DataSet = New DataSet("Type")
				Dim dt As DataTable = ds.Tables.Add("Header")

				T_CUR_YEAR = Now.ToString("yyyy")
				T_YEAR = CInt(T_CUR_YEAR)

				dt.Columns.Add("CODE")
				dt.Columns.Add("NAME")

				For i = 0 To 6
					dt.Rows.Add()
					dt.Rows(i)("CODE") = (T_YEAR - i).ToString
					dt.Rows(i)("NAME") = (T_YEAR - i).ToString
				Next

				S_YEAR.DataSource = dt
				S_YEAR.SelectedValue = T_CUR_YEAR
				
		*********************************파라메터******************************************* 
				Dim params() As Object = {ds}
				
		*********************************출력물 여러건일때 ****************************************** 
							  Dim rpt As New DevExpress.XtraReports.UI.XtraReport
						rpt.CreateDocument()
						Dim rpt2 As New DevExpress.XtraReports.UI.XtraReport
						rpt2.LoadLayout(Common.ReportPath & "\TMS\TmsOrd01Mgt.repx")
						rpt2.DataSource = Common.AdaptDataSourceForReport(ds)
						rpt2.CreateDocument()
						rpt.Pages.AddRange(rpt2.Pages)
						
						리턴후에 사용하면됨
						
						안될때는 데이터테이블 하나만 넣고 로우 2개이상해서 실행해보면될듯
						
		********************************* 네비게이트 간단한 코드 뉴폼 ******************************************   
						Dim fTarget As Object = Nothing
				Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
				fTarget = frmMain.NavigateTo("TmsOrd01List", NavigatedWindowModes.Dialog, False)
				fTarget.Show()
		********************************* 폼 열때 기능 ******************************************   

		  Me.TopMost = True '폼 항상 위에
		  Me.Location = New System.Drawing.Point(Me.Location.X, 0) '중앙상단에 폼 띄우기.
		  
		********************************* DOCUMENT 이미지 불러오기  ******************************************   
		참조(BIZ):sql = New SqlBox("TmsOrd01Mgt@SearchImage")
						sql.Blocks("OFFICE_CD") = True
						sql.Blocks("MNGT_NO") = True
						sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
						sql.Params("MNGT_NO") = drHeader("SO_NO").ToString
						dt = db.SqlGet(sql.Text, False)
						dt.TableName = "Image"
						ResultDs.Tables.Add(dt)
			(sqL):--TmsOrd01Mgt@SearchImage
		SELECT MNGT_NO
			 , SEQ
			 , DOC_TYPE
			 , DOC_NO
			 , FILE_NM
			 , FILE_PATH
			 , SUBSTR(FILE_NM, INSTR(FILE_NM, '.', -1) + 1, LENGTH(FILE_NM) - INSTR(FILE_NM, '.', -1)) FILE_ICON
			 , RMK
			 , INS_YMD
			 , 'Y' AS SUCCESS
		  FROM COM_DOC_MST
		 WHERE 1 = 1
		 [OFFICE_CD]
		   AND OFFICE_CD = '@OFFICE_CD'
		 [/OFFICE_CD]
		 [MNGT_NO]
		   AND MNGT_NO = '@MNGT_NO'
		 [/MNGT_NO] 
		 
		 코드:Public Sub SetImage(ByVal dt As DataTable)

				Dim dr As DataRow = Nothing

				For index = 0 To dt.Rows.Count - 1
					dr = dt.Rows(index)
					Select Case dr("DOC_TYPE")
						Case "PKU"
							PKU_PIC.Image = Image.FromFile("D:\ABC\WebApp" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString())
						Case "GET"
							GET_PIC.Image = Image.FromFile("D:\ABC\WebApp" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString())
						Case "ARP"
							ARP_PIC.Image = Image.FromFile("D:\ABC\WebApp" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString())
						Case "DMG"
							DMG_PIC.Image = Image.FromFile("D:\ABC\WebApp" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString())
					End Select
				Next
				
			End Sub
			
		 테이블:COM_DOC_MST 

		********************************* 리턴 함수 만들기  ******************************************   
		 Public Shared Function RptParams(ByVal ds As DataSet) As Dictionary(Of String, Object)
				Dim searchParams As Dictionary(Of String, Object)


				Return searchParams
			End Function

		*********************************수정안된 데이터 alter 문자 안뜨게 하는 소스 ******************************************   
		Me.DataState = UI.DataStates.Retrieved

		******************************** 폼 새창일때 부모값 받아오기 ******************************************
		Dim NaviForm As Object = Common.IMainForm.NavigateTo("MdmCustomerMgt", NavigatedWindowModes.Dialog, False)

		******************************** image -path ******************************************
		''경로 수정필요
				Dim dr As DataRow = Nothing

				'Try
				For index = 0 To dt.Rows.Count - 1
					dr = dt.Rows(index)
					Select Case dr("DOC_TYPE")
						Case "PKU"
							'PKU_PIC.Image = Image.FromFile("D:\ELVIS_ABC" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString()) '배포서버
							PKU_PIC.ImageLocation = "http://210.180.118.87:8097" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString() '로컬
						Case "GET"
							'GET_PIC.Image = Image.FromFile("D:\ELVIS_ABC" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString())
							GET_PIC.ImageLocation = "http://210.180.118.87:8097" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString()
						Case "ARP"
							'ARP_PIC.Image = Image.FromFile("D:\ELVIS_ABC" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString())
							ARP_PIC.ImageLocation = "http://210.180.118.87:8097" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString()
						Case "DMG"
							'DMG_PIC.Image = Image.FromFile("D:\ELVIS_ABC" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString())
							DMG_PIC.ImageLocation = "http://210.180.118.87:8097" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString()
					End Select
				Next


		파일 저장시킬때 rpt.ExportToPdf("C:\제비\ASDF.pdf")

		폼 사이즈 조절안되게 FormBorderStyle = FixedDialog

		***************************사이트 창 안열고 데이터 전달 POST***************************** 참조 ABC-TMSORD01MGT(SAVE,DELETE)
					  Dim vHeaUrl As Object = ""
					params = "ORDER_NO=" + dr1("SO_NO").ToString + "&EDI_ORDER_NO=" + dr1("PO_NO").ToString + "&EIK_CLT_ID=" + dr1("BILL_CD").ToString + "&ITM_ID_CHG=" + dr1("SO_MODE").ToString + "&REG_NAME=" + dr1("USR_ID").ToString
					Dim encoding__1 As Encoding = Encoding.UTF8
					Dim bp As Byte() = encoding__1.GetBytes(params)
					Dim Url As String = "http://1.234.70.53:8080/Accept_WorkOrder_3.asp"
					Dim req As HttpWebRequest = DirectCast(WebRequest.Create(Url), HttpWebRequest)
					req.Method = "POST"
					req.ContentType = "application/x-www-form-urlencoded"
					req.ContentLength = bp.Length
					Dim stream As Stream = req.GetRequestStream()
					stream.Write(bp, 0, bp.Length)
					stream.Close()
					MsgBoxLocalized("EDI오더접수 파일전송 및 오더가 등록되었습니다!", MessageBoxButtons.OK)

		***************************사이트 창 안열고 데이터 전달 GET***************************** 참조 ABC-TMSORD01MGT(SAVE,DELETE)
										Dim params As [String] = "ORDER_NO=" + dr1("SO_NO").ToString + "&EDI_ORDER_NO=" + dr1("PO_NO").ToString + "&EIK_CLT_ID=" + dr1("BILL_CD").ToString + "&ITM_ID_CHG=" + dr1("SO_MODE").ToString + "&REG_NAME=" + dr1("USR_NM").ToString
						Dim Url As String = "http://1.234.70.53:8080/Accept_WorkOrder_4.asp"
						Dim req As HttpWebRequest = DirectCast(WebRequest.Create(Url + "?" + params), HttpWebRequest)
						req.Method = "GET"
						req.ServicePoint.Expect100Continue = False '반환안받음 설정'
						req.CookieContainer = New CookieContainer()
						req.GetResponse()
						
						참조사이트:http://happytomorrow.net/202 (반환받는것도 있음)
						
						
		**post**
		protected void HttpCall()
		{
		String callUrl = "http://localhost:8080/test/call";
		 String[] data = new String[1];
		 data[0] = "nikemodel";         // id
		 data[1] = "password";          // pw
		  
		 String postData = String.Format("id={0}&pw={1}, data[0], data[1]);
		 HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(callUrl);
		 // 인코딩 UTF-8
		 byte[] sendData = UTF8Encoding.UTF8.GetBytes(postData);
		 httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
		 httpWebRequest.Method = "POST";
		 httpWebRequest.ContentLength = sendData.Length;
		 Stream requestStream = httpWebRequest.GetRequestStream();
		 requestStream.Write(sendData, 0, sendData.Length);
		 requestStream.Close();
		 HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();
		 StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));   
		 string return = streamReader.ReadToEnd();
		 streamReader.Close();
		 httpWebResponse.Close();
		 console.Write("return: " + return);
		}

		http://jp1020.tistory.com/entry/HttpWebRequest-%ED%81%B4%EB%9E%98%EC%8A%A4%EB%A5%BC-%ED%99%9C%EC%9A%A9%ED%95%9C-POST-%EC%A0%84%EC%86%A1
		출처: http://jp1020.tistory.com/entry/HttpWebRequest-클래스를-활용한-POST-전송 [메모하는 습관]
				 
		-------------------------------------------------
		VB-LPAD

		dr("SEQ").ToString().PadLeft(2, "0")

		픽쳐박스(이미지 크기맞게 조절)

		 PKU_PIC.SizeMode = PictureBoxSizeMode.StretchImage

		**그리드 선택된값 가지고오기**
		GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_NM").ToString

		*************************** 그리드 콤보박스 데이터가지고오기*****************************
		editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
				editorCombo.ValueMember = "CODE"
				editorCombo.DisplayMember = "NAME"
				editorCombo.NullText = ""
				searchParams = New Dictionary(Of String, Object)
				dataParams = New Dictionary(Of String, Object)
				dataParams.Add("Type", "")
				'dataParams.Add("NameType", "")
				editorCombo.ShowHeader = False
				editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("Freight", searchParams, dataParams)
				'AddHandler editorCombo.EditValueChanged, AddressOf ChangePkgUnit
				FGV1.Columns("FARE_CD").ColumnEdit = editorCombo


		*************************** 체크콤보 바인딩 ***************************

		 SELL_BUY_CB.Properties.DataSource = ds.Tables("Data.SELL_BUY_CB")
					SELL_BUY_CB.Properties.ValueMember = "CODE"
					SELL_BUY_CB.Properties.DisplayMember = "NAME"
					SELL_BUY_CB.Properties.SeparatorChar = ";"
					SELL_BUY_CB.CheckAll()

		*************************** 문자열 자르기 ***************************
		 For index = 0 To TestArrayy.Length - 1

					If index = TestArrayy.Length - 1 Then
						MsgBox(TestArrayy(index))
						Exit For
					Else
						MsgBox(Mid(TestArrayy(index), 1, TestArrayy(index).Length - 1).ToString)
					End If
				Next

		*************************** 간단한 SAVE or delete ***************************
		 Try
							If ALOC_CANCEL_CB.SelectedIndex = 1 Then
								dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.TmsAloc02Mgt", "Delete", Me.ConvertToDataset)
							Else
								dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.TmsAloc02Mgt", "Delete2", Me.ConvertToDataset)
							End If
						Catch ex As Exception
							MsgBoxLocalized(ex.Message)
							Exit Sub
						End Try

		biz)
		 Public Shared Function Delete(ByVal ds As DataSet) As Dictionary(Of String, Object)
					Dim ResultSet As New Dictionary(Of String, Object)
					Dim db As DBA = New DBA()
					Dim drHeader As DataRow
					Dim dr1 As DataRow = Nothing
					Dim dt1 As DataTable = Nothing
					Dim sql As SqlBox
					Dim ErrorOccur As Boolean = True

					'Transaction 시작
					db.BeginTransaction()

					Try
						Dim dt As DataTable = ds.Tables("WG1")
						For index = 0 To dt.Rows.Count - 1
							'sql = New SqlBox("TmsAloc02Mgt@SearchValidate")
							'drHeader = ds.Tables("WG1").Rows(index)
							'sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
							'sql.Params("SO_NO") = drHeader("SO_NO").ToString & ""
							''dr1 = db.SqlGet(sql.Text, False).Rows(0)
							'dt1 = db.SqlGet(sql.Text, False)

							'For i = 0 To dt1.Rows.Count - 1
							'    dr1 = dt1.Rows(i)
							'    If dr1("SELL_BUY_TYPE").ToString & "" = "S" And dr1("INV_FLAG").ToString & "" = "Y" Then
							'        ThrowMsg(ErrorOccur, "Invoice is closed!")
							'    End If
							'    If dr1("SELL_BUY_TYPE").ToString & "" = "B" And dr1("COST_FLAG").ToString & "" = "Y" Then
							'        ThrowMsg(ErrorOccur, "Cost Invoice is closed!")
							'    End If
							'Next

							'sql = New SqlBox("TmsAloc02Mgt@SearchValidate2")
							'sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
							'sql.Params("SO_NO") = drHeader("SO_NO").ToString & ""
							'dt1 = db.SqlGet(sql.Text, False)
							'For i = 0 To dt1.Rows.Count - 1
							'    dr1 = dt1.Rows(i)
							'    If dr1("SLIP_NO").ToString & "" <> "" Then
							'        ThrowMsg(ErrorOccur, "Tax Invoice is exists!")
							'    End If
							'    If dr1("TAX_NO").ToString & "" <> "" Then
							'        ThrowMsg(ErrorOccur, "Slip is exists!")
							'    End If
							'    'If dr1("INV_NO").ToString & "" <> "" Then
							'    '    ThrowMsg(ErrorOccur, "Invoice No is exists!")
							'    'End If
							'    'If dr1("GRP_NO").ToString & "" <> "" Then
							'    '    ThrowMsg(ErrorOccur, "Invoice Group No is Exists!")
							'    'End If
							'Next

							sql = New SqlBox("TmsAloc02Mgt@Delete")
							drHeader = ds.Tables("WG1").Rows(index)
							If dt.Rows(index)("CHK") = "Y" Then
								sql.Params("SO_NO") = drHeader("SO_NO").ToString & ""
								sql.Params("MNGT_NO") = drHeader("SO_NO").ToString & ""
								sql.Params("INV_NO") = drHeader("INV_NO").ToString & ""
								sql.Params("ALOC_GB") = "A" 'A 일반배차 B 구간배차'
								db.SqlSet(sql.Text)
							End If
							sql = New SqlBox("TmsAloc02Mgt@StatUpdate")
							sql.Params("SO_STAT") = "01" '오더상태(01:등록,02:오더취소,03:오더복구,04:배차)
							sql.Params("SO_NO") = drHeader("SO_NO").ToString & ""
							db.SqlSet(sql.Text)
						Next

						db.Commit()
						ResultSet("TrxCode") = "Y"
						ResultSet("TrxMsg") = "Success"

					Catch ex As Exception
						db.Rollback()
						If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
						ResultSet("TrxMsg") = ex.Message
					Finally
						db.EndTransaction()
					End Try

					Return ResultSet

				End Function

		*************************** 컬럼 contain ***************************
		함수(a~~~~ ByVal e As DevExpress.XtraGrid.Views.Base)
		If ("VERT").Contains(e.Column.FieldName) -- 앞에 필드명 적어주면 된다

		*************************** DataSet add 에러 ***************************
		ds.Tables.Add(dt.Copy());
		**안될경우에 PUBLIC 변수에 담고있다가 SEARCH 끝나고 BINDING 후에 넣어주면됨

		*** 서버 이미지 가지고오기 ***
		http://210.180.118.87:8097/EDMS/DOC/ABC.ELVIS.COM/ABC/20170905/AEE2017090500127_1_170905141744_20170905_141741.jpg

		*************************** 그룹권한 가지고오기 ***************************
		If ClientSessionInfo.AuthorizationType = 0 Then

		*************************** 문자열 검색 (찾는 문자열이 있으면 TRUE 반환 ***************************
		If InStr(MBL_NO.Text, GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("MBL_NO"))) Then 
							MBL_NO.Text = MBL_NO.Text.Replace(GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("MBL_NO")) + ";", "") 
						End If
						
						없으면 0 있으면 1 반환하는듯

		*************************** IN 갯수 초과됬을경우 ***************************
		AND (0,A.MNGT_NO) IN ((0,'@SO_NO')) EX)@SO_NO = 

		*************************** 파일업로드/다운로드 *************************** 참고 TmsCls01Mgt-Email or EmailList
		파일업로드
		FileUpload(업로드할 파일 패스) -C\~~파일명.확장자까지

		COMMON VB에 FILEUPLOAD PATH 
		SavePath As String = "/EDMS/DOC/ABC.ELVIS.COM/EMAIL/

		다운로드
		path = "http://210.180.118.87:8097" + GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1.Columns("FILE_NM")).ToString (뒤에 PATH 는 EDMS//EMAIL//파일명.확장자명)

		*************************서버에 있는 파일 가지고올때 *********************
		실제경로 : http://210.180.118.87:8097/EDMS/DOC/ABC.ELVIS.COM/ABC/20171016/ASE2017101200090_1_ADMIN.gif
		코드 : "http://210.180.118.87:8097" + dr("FILE_PATH").ToString() + dr("MNGT_NO").ToString() + "_" + dr("SEQ").ToString() + "_" + dr("FILE_NM").ToString() '로컬
		--------------------------- ORACLE IN 1000개 넘을경우----
		SQL->AND (0,A.INV_NO) IN ((0,'@INV_NO'))  
		BIZ->INVNO.Replace(" ", "").Replace(";", "'),(0,'")

		*************************CELL MERGE *********************
		/Merge 사용한다고 설정
		gvGridView.OptionsView.AllowCellMerge = true;
		 
		 
		private void GvGridView_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
		{
			if (e.Column.FieldName == "Name")//Name 컬럼만 Merge
			{
				var dr1 = gvGridView.GetDataRow(e.RowHandle1); //위에 행 정보
				var dr2 = gvGridView.GetDataRow(e.RowHandle2); //아래 행 정보
		 
				//비교하는 이유 그래야 정상적으로 나옴.
				e.Merge = dr1["Name"].ToString().Equals(dr2["Name"].ToString());
			}
			else           
				e.Merge = false;               
			 
			e.Handled = true;
		}

		##11월 1일자 신규 자료

		**서버에 있는 파일,폴더 가지고올때(중간포트는 IIS 포트:8097) 
		http://210.180.118.87:8097/GPS/gps.asp?LISENCE_NO 

		**하위폴더생성
		Directory.CreateDirectory(FPath) '하위폴더 생성

		**레포트 피시에 저장
		rpt.ExportToPdf(FPath + "\" + FName) '레포트 다운

		**컴퓨터에 저장된 파일명 변경
		My.Computer.FileSystem.RenameFile(PATH, dr1("FULL_NAME").ToString) //파일명 변경

		!PATH:C:\Users\YJIT\Documents\YJIT.SC Home\YJIT.SC.TMS\EMAIL\20171031\월별운송내역서_ABC_지오디스윌슨코리아.pdf
		!FULL_NAME:20171031_223_월별운송내역서_ABC_지오디스윌슨코리아.pdf

		**파일 서버에 저장
		FileUpload(Fpath + "\" + dr1("FULL_NAME").ToString, OFFICE_PATH) //실제 저장되어있는 파일위치,서버안 폴더위치
		!FPATH:C:\Users\YJIT\Documents\YJIT.SC Home\YJIT.SC.TMS\EMAIL\20171031
		!FULL_NAME:20171031_223_월별운송내역서_ABC_지오디스윌슨코리아.pdf
		!OFFICE_PATH:/EDMS/DOC/ABC.ELVIS.COM/EMAIL/

		**그리드 정렬(SORT)
		ds.Tables("WG2").DefaultView.Sort = "FOB_SEQ  ASC " 그리드 정렬  
		dt = dt.DefaultView.ToTable(True)

		**그리드 VISIBLE
		 GV2.Columns("CNT").Visible = True
		 
		**오피스코드 분류
		If ClientSessionOfficeInfo.HqOfficeCode = "ABCHQ" Then
		END IF
		 
		**도메인 분류
		If COMMON Then
		END IF

		**그리드 색상 그리기
		Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle

				Dim currentView As GridView = TryCast(sender, GridView)

				For index = 0 To 12
					Dim EVT As String = "EVT_" + (index + 1).ToString.PadLeft(2, "0")
					If e.Column.FieldName = EVT Then 'EVT_01~EVT_12까지
						Dim Process As String = GV1.GetRowCellValue(e.RowHandle, EVT)
						Select Case Process
							Case "P" 'YELLOW
								e.Appearance.BackColor = Color.Yellow
							Case "W" 'RED
								e.Appearance.BackColor = Color.Red
							Case "C" 'BLUE
								e.Appearance.BackColor = Color.DeepSkyBlue
							Case "N" 'GRAY
								e.Appearance.BackColor = Color.Gray
						End Select
						Exit For
					End If
				Next

			End Sub
			
		**ADDROW 일때만 수정가능하게
		이벤트는 : GV1_FocusedRowChanged
		If GV1.GetFocusedDataSourceRowIndex() >= 0 Then
					If Not IsNothing(GV1.GetFocusedDataRow().RowState) Then
						If GV1.GetFocusedDataRow().RowState = DataRowState.Added Then
							Me.GV1_GRP_CD.OptionsColumn.AllowEdit = True
							Me.GV1_GRP_CD.OptionsColumn.ReadOnly = False
							Me.GV1_GRP_ROUTE_CD.OptionsColumn.AllowEdit = True
							Me.GV1_GRP_ROUTE_CD.OptionsColumn.ReadOnly = False
						Else
							Me.GV1_GRP_CD.OptionsColumn.AllowEdit = False
							Me.GV1_GRP_CD.OptionsColumn.ReadOnly = True
							Me.GV1_GRP_ROUTE_CD.OptionsColumn.AllowEdit = False
							Me.GV1_GRP_ROUTE_CD.OptionsColumn.ReadOnly = True
						End If
					End If
				End If
				
		** for each index 가지고오기
		For Each dr In dt2.Rows
		If dt2.Rows.IndexOf(dr) = 0 Then

		**tab change 가지고오기
		XtraTabControl1_SelectedPageChanged 함수
		XtraTabControl1.SelectedTabPageIndex = 2 - 인덱스 (if문)

		*excel 출력시 글씨체,글씨크기 // 테두리 검정색

		1.글시체 : RunDeginer - Columns - AppearanceCell - Font
		2.테두리 : RunDeginer - GV1 - AppearancePint-Lines-Black

		*foreach
		For Each Column As DevExpress.XtraGrid.Columns.GridColumn In GV1.Columns
								'Column.AppearanceCell.Font = New Font(Column.AppearanceCell.Font.Size, 12)
					Column.AppearanceCell.Font = New Font("Vijaya", 12, FontStyle.Regular)
				Next
				
		*Procedure 프로시져(프로시저)
		 Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
							param("P_OFFICE_CD") = dr("OFFICE_CD").ToString
							param("P_MNGT_NO") = dr("MNGT_NO").ToString
							param("P_EVT_CD") = dr("EVT_CD").ToString
							param("P_EST_YMD") = dr("EST_YMD").ToString
							param("P_EST_HM") = dr("EST_HM").ToString
							param("R_RTNCD") = ""
							param("R_RTNMSG") = ""

							db.ExecuteProcedure("USP_RUT_ESTIMATE", param)

							If ("" & param("R_RTNCD").ToString) = "E" Then
								ThrowMsg(ErrorOccur, param("R_RTNMSG").ToString)
							End If

		*시간체크,측정(TIME) ms
		Dim sw As New Stopwatch
				sw.Start()
				Dim A As Stopwatch = sw
				SearchData()
				sw.Stop()
				Dim B As Stopwatch = sw
				MessageBox.Show("시작:" + A.ElapsedMilliseconds.ToString + "ms" + " 종료:" + B.ElapsedMilliseconds.ToString + "ms")
				
		*시간측정,체크 Nano
						Dim centuryBegin As Date = Date.Now
				SearchData()
				Dim currentDate As Date = Date.Now
				Dim elapsedTicks As Long = currentDate.Ticks - centuryBegin.Ticks
				Dim elapsedSpan As New TimeSpan(elapsedTicks)
				MessageBox.Show("소요시간:" + (elapsedSpan.TotalSeconds).ToString + "초")
				
				'MessageBox.Show((elapsedTicks * 100).ToString + "Nanoseconds")
				'MessageBox.Show((elapsedSpan.TotalMinutes).ToString + "Minutes")
				
				
		***중요*** (COM_DOC_MGT)

		D:\ABC\WebApp\EDMS\DOC\ABC.ELVIS.COM\ABC\20180117\ASEM2017122800006_1_180117114856_20180117_114913 --로컬
		D:\ELVIS_ABC\EDMS\DOC\ABC.ELVIS.COM\ABC\20180117\ASEM2017122800006_1_180117114856_20180117_114913 --서버

		HttpContext.Current.Server.MapPath

		로컬 D:\ABC\WebApp 경로
		배포 D:\ELVIS_ABC 경로

		**(데이터테이블에 로우 하나씩 add로우 하기) - ImportRow addrow merge
		기존 dt
		새로운 dt1

		dt1 = dt.copy
		dt1.clear

		조건맞는것
		dt.importrow(dt.rows(i))

		문자열포함
		InStr(변수명, 찾을데이터) ->EX)InStr(drHeader("SO_MODE").ToString, "01")
		or
		InStr(drHeader("OFFICE_CD").ToString, "서울본사") 문자가있으면 글자수 정수반환 아니면 0반환

		그리드 로우 깔끔하게 삭제
		ds.Tables("FWG1").Rows(index).Delete()

		**로그인관련정보
		appcode-sys-common
		clientSessionOfficeinfo vb
		login sql
		YJIT.WCF 폴더 BIZSERVICE

		**MAC ADDRESS 확인방법

		CMD-IPCONFIG/ALL   -> 이더넷 어댑터 로컬 영역 연결-물리적주소(-제외 12자리)


		**날짜생성 자동날짜
		Dim dt As DataTable = New DataTable
				dt.Columns.Add("CODE")
				dt.Columns.Add("NAME")

				For index = 0 To 30
					dt.Rows.Add()
					Dim DateTime As String = System.DateTime.Now.AddYears(-index).ToString("yyyy")
					dt.Rows(index)("CODE") = DateTime
					dt.Rows(index)("NAME") = DateTime + "년"
				Next
				Year_cb.DataSource = dt
				
		** 그룹패널 숫자 ,보이게
		{0:n0} 소수점 없음
		{0:n1} 소수자리 1개
		{0:n2} 소수자리 2개

		*날짜문자열 자르기
		S_DATE_FM.Text.Substring(0, 4) 년도 2018
		S_DATE_FM.Text.Substring(4, 2) 월 10월

		*column 컬럼명 가지고오기

		Dim a As String = ds.Tables("wg1").Columns(0).ToString

		*Dim form_name = DirectCast(sender, DevExpress.XtraBars.BarManager).ActiveMdiChild.Text  -> object에 들어있는 폼명 추출하기


		*ip,macadress 가지고오기

		Imports System.Net
		Imports System.Net.NetworkInformation

		Dim IP4Address As String = String.Empty

					For Each IPA As IPAddress In Dns.GetHostAddresses(Dns.GetHostName())
						If IPA.AddressFamily.ToString() = "InterNetwork" Then
							IP4Address = IPA.ToString()
							Exit For
						End If
					Next

					Dim nics() As NetworkInterface = _
								 NetworkInterface.GetAllNetworkInterfaces
					Dim mac As String = nics(0).GetPhysicalAddress.ToString()
					
		** TCP 포트 (참조:http://hyeonstorage.tistory.com/287 or http://knight76.tistory.com/entry/30023688287)
		포트 close_wait

		netstat -na 포트확인

		netstat -ano pid 확인

		netstat -ano | findstr 4000 - 원하는 포트확인

		LISTEN　　　<-- 포트가 열렸음
		ESTABLISHED <-- 서로 연결중
		CLOSE_WAIT　<-- 종료 대기중

		LISTEN : 서버의 데몬이 떠서 접속 요청을 기다리는 상태 

		SYS-SENT : 로컬의 클라이언트 애플리케이션이 원격 호스트에 연결을 요청한 상태 

		SYS-RECEIVED : 서버가 클라이언트로 부터 접속 요구를 받아 클라이언트에게 응답을 했지만 아직 클라이언트에게 확인 메세지는 받지 않은 상태 

		ESTALISHED : 3Way Handshaking 완료된후 서로 연결된 상태 

		FIN-WAIT, CLOSE-WAIT, FIN-WAIT2 : 서버에서 연결을 종료하기 위해 클라이언트에게 종결을 요청하고 회신을 받아 종료하는 과정의 상태 

		CLOSING : 흔하지 않지만 주로 확인 메세지가 존송 도중 분실된 상태 

		TIME-WAIT : 연결은 종료 되었지만 분실되었을지 모를 느린 세그먼트를 위해 당분간 소켓을 열어 놓은 상태 

		CLOSED : 완전히 종료

		***WITH

		With ds.Tables(ds.Tables(index).TableName)

		 .ROW~~
		 .~~ 
		End With


		**업로드(upload방법)

		사진전송
		comdocmgt
		comdocmgt.vb
		common -> fileupload

		전송에러뜨면 폴더생성안된것 확인하고 폴더권한주기

		**디버그안될때
		DEBUG 안될때
		YJIT.SC.FMS->YJIT.SC.APP 으로 시작프로젝트 설정 변경

		**사진정송 안될때
		전송하는 폴더 권한에서 모든권한 줘야함

		**이메일전송 안될때(email)

		아웃바운드 25포트(tcp) 열어줘야함

		**gps 한글깨질때 지도안뜰때

		다른이름저장 눌러서 utf 8 로 저장해줘야됨
		지도가 안뜨는건 다음 api 사이트들어가서 포트열어줘야됨

		**ping 핑 ip 확인 

		cmd -> svn.yjit.co.kr

		**텍스트박스 숫자만 받기(숫자 아닐경우 if문 안쪽 걸러내기)
		If Not IsNumeric(e.KeyChar) Then
					If e.KeyChar <> ControlChars.Back Then
						e.KeyChar = ControlChars.NullChar
					End If
				End If
			   
		** Combobox 정보
					  Dim a = REQ_SVC.SelectedIndex - 선택한 인덱스
				Dim b = REQ_SVC.SelectedItem - 콤보박스 정보
				Dim c = REQ_SVC.SelectedText -  ?
				Dim d = REQ_SVC.SelectedValue - 선택한 값
				
		** 레지스트리 정보
		HKEY_CLASSES_ROOT - 파일연결
		HKEY_CURRENT_USER - 현재 로그인한 사용자의 설정
		HKEY_LOCAL_MACHINE - 컴퓨터의 모둔 사용자의 설정
		HKEY_USERS - 각 사용자의 프로파일에 대한 HKEY_CURRENT_USER의 서브키를 담고 있다
		HKEY_CURRENT_CONFIG - 실행 시간에 수집한 자료를 담고 있다.

		**우클릭 ADDROW 
		Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
				Dim Key As String = Dr("Key")
				Dim Sender As String = Dr("Sender")
				Dim Id As String = ""

				If Key = "Enter" Then Id = Dr("ID")

				'Navigato 사용할떄
				Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
				Dim fTarget As Object = Nothing
				Dim rowIndex As Integer = 0

				Select Case Dr("Action")
					Case Action.NavigateTo
						frmMain = Me.MdiParent
					Case Action.Addrow
						Select Case Sender
							Case "WG2"
								Dim Index As Integer = GV2.FocusedRowHandle
								If Index > 0 Then
									GV2.SetRowCellValue(Index, "SEQ", GV2.GetRowCellValue(Index - 1, "SEQ") + 1) 'rowindex 사용하면안됨'
								Else
									GV2.SetRowCellValue(Index, "SEQ", 1)
								End If
						End Select
				End Select
			End Sub
			
		   
		**ORACLE DECODE 처럼 VB에서 IIF가 있음

		형식 : IIf(drHeader("USE_YN") = "", "Y", drHeader("USE_YN").ToString)

		IIF(조건문,참일때,거짓일때)

		**체크박스 CHECKBOX -

		evExpress.XtraEditors.CheckEdit -> YJIT.SC.UI.SCControls.CheckBox 로 변경

		**date.now.Tostring AM/PM 포맷 - 비추천

		Now.ToString("yyyy-MM-dd tt HH:mm:s")

		24시간 포맷 - 추천
		Now.ToString("yyyy-MM-dd tt HH:mm:ss")

		ORACLE 에 넣을때는 SELECT to_date('2018-07-05 15:19:51','YYYY-MM-DD HH24:MI:SS') FROM DUAL

		문자열 변환 Now.ToString("yyyy-MM-dd tt HH:mm:s").Replace("AM", "오전").Replace("PM", "오후")


		**성능모니터
		기존꺼에 그래프 추가 process-Privileged Time 선태하고 원하는 프로세스 선택추가하면됨

		**.Select 방식으로 데이터 row 가지고오기
		Dim DRS() As DataRow = Nothing
		DRS = Ds.Tables("SDS_SHPINFEVN").Select("CurrentEvent = 'X' AND MSGID = '" & MsgId & "'")

		변수 AA = DRS(0)("컬럼명") 방식으로 사용해야됨 (0) 빠지면 에러남

		**배열

		dim a as string()
		a = {"1","2","3"}

		** DO WHILE 설명
			Do
			  stringReader = fileReader.ReadLine()
		  Loop While stringReader IsNot Nothing
		  
		** delete row(찌꺼기 남을때)
		Table.Rows.Remove(Table.Rows(i))

		Dim DT As DataTable = tempds.Tables("MAIN")

				Dim dr11() As DataRow
				dr11 = tempds.Tables("WG2").Select("VAL_CHK = '" & "Y" & "'")

				Dim BB As DataTable
				BB = tempds.Tables("WG2").Select("VAL_CHK = '" & "Y" & "'").CopyToDataTable
				
		**원하는 로우(ROW)만 가지고 오고싶을때
		Dim tempds As DataSet = Me.ConvertToDataset()
		Dim DT As DataTable = tempds.Tables("WG2")
		Dim CC = DT.Select("SEND_CHK = '" & "Y" & "'").Skip(0).Take(3000).CopyToDataTable


		파일 읽기,만들기,쓰기,복사(FileStream)

		1)읽기

		2)만들기 
		Dim fs As FileStream = File.Create(cITTS_FilePath + "\" + cITTS_Filenm) '파일 만들기

		3)쓰기
		Dim info As Byte() = New UTF8Encoding(True).GetBytes(F_Str) '파일 내용쓰기
										fs.Write(info, 0, info.Length)
										fs.Close() '메모리 해제
										
		4)복사          
		File.Copy(cITTS_FilePath + "\" + cITTS_Filenm, cITTS_FilePath + "_LOG\" + NowMonth + "\" + cITTS_Filenm) '복사

		5)삭제
		FileIO.FileSystem.DeleteFile(MovePath)

		**폴더만들기
		FileIO.FileSystem.CreateDirectory(cITTS_FilePath + "_LOG\" + NowMonth) '로그폴더생성                  

		**db.SqlGet = nothing뜰때
		db.SqlGet(sql.Text) -> db.SqlGet(sql.Text, False)로 사용
			
		**배열 문자열 포함확인
		Recv.Contains(Item) = True

		**날짜 24시간
		System.DateTime.Now.ToString("yyyyMMdd HH-mm")

		**IP,MACADDRESS 로그아웃정보 로그 남기기
		Dim IP4Address As String = String.Empty
							For Each IPA As IPAddress In Dns.GetHostAddresses(Dns.GetHostName())
								If IPA.AddressFamily.ToString() = "InterNetwork" Then
									IP4Address = IPA.ToString()
									Exit For
								End If
							Next

							Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
							Dim mac As String = nics(0).GetPhysicalAddress.ToString()

							Dim db As New DBA()
							Dim sql As SqlBox
							sql = New SqlBox("Login@InsertLog")
							sql.Params("USR_ID") = SessionInfo.UserID
							sql.Params("MSG") = "Logout"
							sql.Params("IP") = IP4Address
							sql.Params("MAC_ADDR") = mac
							db.SqlSet(sql.Text)
							
		**파일 열기
		Dim p As New System.Diagnostics.Process
				Dim s As New System.Diagnostics.ProcessStartInfo("D:\ABC\YJIT.SC.FMS\bin\Debug\TMP_OUTPUT\11.xlsx")
				s.UseShellExecute = True
				s.WindowStyle = ProcessWindowStyle.Normal
				p.StartInfo = s
				p.Start()                  
							
		**엔터키 입력받기
		If e.KeyCode = Keys.Enter Then
					SearchBlNo()
				End If                   
				
		**엑셀 EXPORT
		Private Sub ExcelData()
				Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(WG2.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
				If Not View Is Nothing Then
					If dlgSaveExcel.ShowDialog() = DialogResult.OK Then
						View.OptionsPrint.ExpandAllDetails = True
						View.ExportToXls(dlgSaveExcel.FileName)
						If MsgBoxLocalized("Do you want open this file?", MessageBoxButtons.YesNo, "Open", MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then '메시지박스 O
							Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
							process.StartInfo.FileName = dlgSaveExcel.FileName
							process.StartInfo.Verb = "Open"
							process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
							process.Start()
						End If
						'MsgBoxLocalized("Excel export complete!", , True) '메시지박스 X
					End If
				End If
		End Sub

		**엑셀 IMPORT
		Public Sub UploadExcel()
				Dim sExcelPath As String
				Dim dlgExcel As New OpenFileDialog

				With dlgExcel
					.Title = "Open excel file..."
					.Filter = "Excel Spreadsheets (*.xls)|*.xls|Excel 2007 and later (*.xlsx)|*.xlsx"
					.FilterIndex = 1
					.CheckFileExists = False
				End With

				If dlgExcel.ShowDialog() = DialogResult.OK Then
					sExcelPath = dlgExcel.FileName
				Else
					Exit Sub
				End If

				'convert excel file to dataset
				Dim dsExcel As DataSet = ExcelConnection.ImportExcel(sExcelPath)
				Dim dtExcel As DataTable = dsExcel.Tables(0)

				For i = 0 To GV1.Columns.Count - 1
					dtExcel.Columns(i).ColumnName = GV1.Columns(i).FieldName
				Next

				'Finally, display data to grid

				Dim dt As DataTable = dtExcel.Copy

				WG1.DataSource = dt

				Me.DataState = UI.DataStates.New
				
		End Sub

		**Bizservice - 
		Public Overridable Function SendYTOInterface(ByVal ds As DataSet) As DataSet Implements IBizService.SendYTOInterface
					Dim dt As DataTable = New DataTable
					dt.Columns.Add("USERID")
					dt.Columns.Add("PASSWORD")
					dt.Columns.Add("DOMAIN")
					dt.Rows.Add()
					dt.Rows(0)("USERID") = "ADMIN"
					dt.Rows(0)("PASSWORD") = "0000"
					dt.Rows(0)("DOMAIN") = "ICSK.SCM.COM"
					dt.TableName = "WCF_CLIENT_INFO"
					ds.Tables.Add(dt)

					Dim dictReturn As New Dictionary(Of String, Object)
					Dim Params As Object = Nothing
					Params = {ds, False}
					processSessionDomain(ds.Tables("WCF_CLIENT_INFO"))
					dictReturn = invokeMethod("YJIT.Biz.HBLIO01", "SaveExcelData", Params)
					Return dict2Ds(dictReturn, Nothing, "")
				End Function
				
		**FOR문 거꾸로
		Try
					For i = params.Tables("FWG1").Rows.Count - 1 To -1 Step -1 'LGD TARIFF FLAG값 I로 변경
						If params.Tables("FWG1").Rows(i)("INS_USR").ToString = "LGD" Then
							If params.Tables("FWG1").Rows(i)("_INSFLAG").ToString = "U" Then
								params.Tables("FWG1").Rows(i)("_INSFLAG") = "I"
							Else
								params.Tables("FWG1").Rows.Remove(params.Tables("FWG1").Rows(i))
							End If
						End If
					Next
				Catch ex As Exception

				End Try
				
		**선택값만 가지고오기
		GV1.GetDataRow(GV1.FocusedRowHandle).SetModified()

		**콤보박스 선택값에 따라 다른 콤보박스 가지고 올때
		Try
					Dim searchParams As Dictionary(Of String, Object)
					Dim dataParams As Dictionary(Of String, Object)
					Dim groupCode As String = ""

					If REQ_SVC.SelectedValue = "AIR" Then
						groupCode = "A07"
					ElseIf REQ_SVC.SelectedValue = "SEA" Then
						groupCode = "B07"
					ElseIf REQ_SVC.SelectedValue = "TMS" Then
						groupCode = "T06"
					Else
						groupCode = ""
					End If
					' Service Term
					searchParams = New Dictionary(Of String, Object)
					dataParams = New Dictionary(Of String, Object)
					dataParams.Add("GroupCode", groupCode)
					dataParams.Add("NameType", "A")
					Dim dt As DataTable = New DataTable
					dt.Columns.Add("CODE")
					dt.Columns.Add("NAME")
					dt.Rows.Add()
					dt.Rows(0)("CODE") = ""
					dt.Rows(0)("NAME") = "--Select--"
					SVC_TYPE.DataSource = dt '에러날 경우 --Select--만 표시
					dt.Merge(Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams))
					SVC_TYPE.DataSource = dt
				Catch ex As Exception

				End Try
				
		*파일이름 가지고오기

		*그리드 속성 SORT 초기화,검색창 없애기
		GV1.ClearSorting() 
		GV1.HideFindPanel()
		
	End Sub


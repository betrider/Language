//#모두접기 Alt+0 / 모두펼치기 Alt+Shift+0 / 기호 양식순서 1. -> 1) -> (1)

package D:\개발노트\코드 
 
import https://devnudie.tistory.com/entry/eclipse%EC%9D%B4%ED%81%B4%EB%A6%BD%EC%8A%A4-%EC%9C%A0%EC%9A%A9%ED%95%9C-%EB%8B%A8%EC%B6%95%ED%82%A4 //STS단축키

public class java {
	
	public static void main(String[] args){
		
		stsShortCutKey();
		javaScript();
		jsp();
		java();
		xml();
		
	}
	
	public void stsShortCutKey(){
		
		[블록]
		Shift + ←, Shift + →	좌우로 한 캐릭터 단위 블록	
		Shift + ↑, Shift + ↓	상하로 한 줄 단위 블록	세로 편집 모드에서 사용시 줄이 아닌 캐릭터로 블록
		Ctrl + Shift + ←, Ctrl + Shift + →	좌우로 단어(캐릭터의 대소구별) 단위 블록	
		Shift + Alt + ↑ ( ←, → )	연속된 문자열 블록	변수명이나 메소드명 블록(↑추가 입력시 중괄호 전체를 블록 가능하며 ←, → 키를 입력시 메소드 단위로 추가 블록 가능, ↓입력시 시간 역순으로 블록에서 제외)
		Shift + Home, Shift + End	커서 위치 부터 줄의 처음/끝까지 블록	줄 전체를 블록하는 경우 커서를 줄의 처음이나 끝으로 이동(Home/End키) 시킨 후 사용
		Ctrl + Shift + Home, Ctrl + Shift + End	커서 위치 부터 문서의 처음/끝까지 블록	

		[검색]
		Ctrl + F	기본 검색	찾기 메뉴를 여는 키로 ALT + D키를 추가로 입력해 위에서 아래로 하나씩 찾으면서 바꾸는데 유용
		Ctrl + K, Ctrl + Shift + K	블럭한 문자열과 동일한 문자열 검색	변수의 사용 횟수 등을 추적
		Ctrl + J	점증적 검색	키를 입력한 후 추가로 입력한 문자열과 동일한 내용으로 이동
		Ctrl + Shift + L	프로젝트 전체 문자열 검색	STS의 기본 플러그인(이클립스에서는 설치해야 함)에 들어간 Quick Search 기능으로 전체 검색 기능인 Ctrl + H 대비 매우 빠른 속도
		Ctrl + Shift + R	파일 이름 검색

		[편집]
		Ctrl + Space	컨텐트 어시스트	기본 자동완성 기능으로 두번 입력시 빠른 Method 생성 가능
		Ctrl + 1	퀵 픽스	새로운 Method, Class 등 관련 객체등을 만들 거나 변경 시 빠르게 작업 할 수 있도록 도움
		Ctrl + Shift + /, Ctrl + Shift + ＼	블록 주석	기본 주석인 Ctrl + /가 한정 된 언어에서 적용되는데 반해 언어 상관없이 동작
		Ctrl + Shift + F	소스 코드 자동 정렬	동작 시 고정폭 문자열로 맞춰놓은 기본 형태가 무너지므로 규모가 작거나 스스로 개발한 파일 안에서만 사용하는 것을 권장
		Ctrl + Shift + O	임포트 추가 및 정리	
		Ctrl + D	한 줄 삭제	
		Ctrl + Alt + ↑, Ctrl + Alt + ↓	한 줄 복제	
		Alt + ↑, Alt + ↓	한 줄 이동	
		Ctrl + Shift + Y, Ctrl + Shift + X	블럭한 문자열을 소문자/대문자로 변경	
		Alt + Shift + J	설정 주석 자동 기입	
		Alt + Shift + S	소스 메뉴 표시	VO, DTO 등의 Getter Setter 와 생성자 자동 완성에 유용, Getter Setter 빠르게 만들기 : R→ALT + A→Shift + Tab→Enter
		Alt + Shift + T	리팩터 메뉴 표시	마지막 키인 T를 R(리네임), V(이동), C(메소드변경), M(메소드추출), L(지역변수화), I(인라인) 키로 대체하여 사용시 리팩터 메뉴에 바로 접근 가능
		Alt + Shift + Z	서라운드 메뉴 표시	블록한 부분을 for, if, try/catch, do/while 등으로 감싸는 메뉴 호출
		Alt + Shift + A	세로 편집 모드 설정/해제	설정 된 상태에서 기존 가로 블록이 세로를 지원

		[이동]
		Ctrl + Shift + ↑, Ctrl + Shift + ↓	클래스의 이전/다음 멤버로 이동	
		Ctrl + Shift + P	매칭되는 괄호로 이동	
		F3	요소의 선언된 곳으로 이동	
		F4	현재 타입의 상속 구조의 표시	
		Ctrl + Alt + H	호출부 표시	Ctrl + T와 함께 호출과 상속을 넘나들며 사용, 키 입력 후 화살표 엔터로 이동
		Ctrl + T	상속부 표시	Ctrl + Alt + H와 함께 호출과 상속을 넘나들며 사용, , 키 입력 후 화살표 엔터로 이동
		Ctrl + <, Ctrl + >	이전/다음 경고로 이동	에러 찾기
		Ctrl + Q	마지막으로 편집한 위치로 이동	
		Ctrl + L	줄 번호로 이동	예외 발생시 해당 줄번호로 이동
		Alt + ←, Alt + →	파일을 열어본 순서에 따라 이전/다음 에디터로 이동	
		Ctrl + E	열려있는 모든 에디터 표시	열려 있지만 화면에 표시 되지 않고 밀려서 숨겨져 있는 에디터들이 진한 글씨로 상단에 먼저 노출
		Ctrl + PgUp, Ctrl + PgDn	다음/이전 열려있는 에디터로 이동	연 순서가 아닌 시각적인 순서에 따라 이동
		Ctrl + F7, Ctrl + Shift + F7	다음/이전 뷰 이동	에디터에서 콘솔이나 서버로 이동하여 조작시 용이
		Ctrl + F8, Ctrl + Shift + F8	다음/이전 퍼스펙티브 이동	스프링, 자바 EE, 디버그 모드 간 이동시 용이
		F12	에디터로 이동	
		Ctrl + M	최대/최소화	콘솔창을 크게 보거나 다른 요소를 배제할 때 용이

		[실행]
		Ctrl + F11	프로젝트 실행	전역 단축키
		F11	디버그 모드 실행	전역 단축키
		Ctrl + Shift + B	해당 줄의 브레이크 포인트 설정/해제	
		F5	한 줄씩 디버그 실행하며 함수 일 경우 내부로 진입	
		F6	한 줄씩 디버그 실행하며 내부 진입 하지 않음	
		F7	디버그 실행 중 함수 밖으로 이동	
		F8	다음 디버그 포인트까지 이동	
		Ctrl + R	해당 줄 디버그 실행	
		Ctrl + Alt + S  ( D, R )	실행 종료 (디버그, 실행)	지역 단축키 (서버 뷰에서만 동작)

		참조:https://devnudie.tistory.com/entry/eclipse%EC%9D%B4%ED%81%B4%EB%A6%BD%EC%8A%A4-%EC%9C%A0%EC%9A%A9%ED%95%9C-%EB%8B%A8%EC%B6%95%ED%82%A4
		
	}
	
	public void javaScript(){
		
		Storage : 키-밸류 스토리지
		localStorage -  인터넷 창 닫아도 데이터 사라지지않음 직접 삭제해줘야함
		SessionStorage - 인터넷 창 닫으면 데이터 사라짐

		<!DOCTYPE HTML>
		<html>
			<head> </head>
			<body> </body>
		</html>
		
	}
	
	public void jsp(){
		
		jsp form태그 속성
		참조:https://m.blog.naver.com/PostView.nhn?blogId=james2021&logNo=30076048663&proxyReferer=https%3A%2F%2Fwww.google.com%2F
		
		~디렉티브 형식 저장(JSP 페이지에 대한 설정 정보 지정)
		page : JSP 페이지에 대한 정보 지정
		taglib : JSP 페이지에서 사용할 태그 라이브러리 지정
		include : JSP 페이지의 특정 영역에 다른 문서 포함

		------------------------------------------------------------------------------
		
		<%@page language="java" contentType="text/html; charset=UTF-8"%>
		include header.jsp
		include commonResource.jsp

		<html> //header.jsp 에서 미리선언
			<head> //header.jsp 에서 미리선언
				<javascript>선언
				
				renderView() // 라벨,버튼,그리드선언,셋팅(Sencha Ext Js - 자바스크립트 프레임워크 사용) 
				{
				 grid01 = Ext.create('VC.grid.CommonGrid,{[셋팅값],columnDefine : [], buttonsConfig : [], listeners : [] }); //일반데이터는 columnDefine에만 선언되도 나오는데 popEditFieldset가 있을경우에는 popEditFieldset,columnDefine 양쪽에 선언되어야 보이는듯
				 viewPort = Ext.create('VC.container.Viewport',{layout, items : [grid01], listeners}); // 화면에 버튼,그리드 등등 할당 - 반응형 웹(기기에 맞게 화면크기 셋팅 스마트폰,PC,아이패드 등등)
				 settingPage();
				}
				

				//변수선언
				 var officeCd = "<%=userInfo.getDevision()%>";
				 var officeNm = "<%=userInfo.getDevisionName()%>";

				//settingPage
				function settingPage(){
				 if( CURRENT_MENUCODE == 'PTL823100' ){
				  Ext.getCmp('newBtnBorder').destroy();
				  Ext.getCmp('newBtnDomestic').destroy();
				 }
				}
				
				//Function
				function search(){
				 //Validation
				 grid01.search(viewPort, 경로, params, false, function(result, successYn) //경로는 java함수까지 - '/fis/portalTrkExHawbRetServiceHTSV/search'
				}

				function save(){
				 //Validation
				 Ext.MessageBox.show({title,msg,buttons,icon,
							 fn : function(btn)
							{
							 if(btn === 'yes')
							 {
							  Ext.Ajax.request({url,jsonData,params,
									call back : function(options, success, response)
									{
									 var json = Ext.decode(response.responseText); //반환값 넘어옴 
									 if(json["ErrorMsg"] === "OK")
									 {
									  Ext.MessageBox.show()
									 }
									 else
									 {
									  Ext.MessageBox.show()
									 }
									}
										 });
							 }	
							 else if (btn === 'no')
							 {
							  return;
							 }			
							}
							});
				}
				
				*배열값 있는지 확인
					if(lccReqList.indexOf(data['DO_ITEM']) >= 0){
    		
					}

				</script>
			</head>
			<body>
			</body>
		</html>

		------------------------------------------------------------------------------

		*head,body 차이
		head : js 처리가 완료되어야 화면이 열린다.(가변운화면에서 좋음)
		body : 화면이 열린 후 js가 처리된다.(무거운화면에서 좋음)
		
	}
	
	public void java(){
		
		--------------------기본형식 --------------------
		package ~
		import ~
		public class ~ (extends ~)
			public~

			public~
		-------------------------------------------------

		*xml(쿼리) 
		파라메터 입력
		paramMap.put("OFFICE_CD", officeCd);
		paramMap.put("DYNAMIC_QUERY", DYNAMIC_QUERY);
		
		*어노테이션 - 메타데이터
		@Service
		@Autowired - 할당값 자동 주입
		@SuppressWarnings - 경고메시지 억제용
		@Repository - 데이터베이스에 접근하는 클래스
		@Authorize
		
		*JQUERY - 자바스크립트 라이브러리
		*MYBATIS - 객체지향 어플리케이션에서 관계형 데이터베이스를 쉽게 사용할 수 있도록 도와주는 데이터 맵핑 프레임워크이다.
		*JSON(JavaScript Object Notation) name-value 형식의 쌍
		{
		  "firstName": "Kwon",
		  "lastName": "YoungJae",
		  "email": "kyoje11@gmail.com"
		}
		list 형식
		{
		  ["firstName": "Kwon","lastName": "YoungJae","email": "kyoje11@gmail.com"]
		  ["firstName": "Kwon","lastName": "YoungJae","email": "kyoje11@gmail.com"]
		  ["firstName": "Kwon","lastName": "YoungJae","email": "kyoje11@gmail.com"]
		}
		*MAVEN - 라이브러리 라이프 사이클 관리도구(pom.xml)
		업데이트 방법 프로젝트 우클릭 -> maven -> Update Project(Alt+F5)

		3.자료구조
		Collection(key-value, 중복x)
		Map - map interface
		HashMap(key-value쌍,중복x,null o)
		TreeMap(key-value쌍,중복x,정렬 o)
		HashTable(key-value쌍,중복x,null x)

		4.var,let,const
		var - function scoped
		let - block scoped
		const - 초기선언후 재할당 불가능

		5.extend,implement 차이점
		extend - 상속(메소드 그대로 사용가능)
		implement - 인터페이스(메소드 다시 선언후 사용가능)
		https://hashcode.co.kr/questions/471/implements%EC%99%80-extends%EC%9D%98-%EC%B0%A8%EC%9D%B4%EC%A0%90%EC%9D%B4-%EB%AD%90%EA%B3%A0-%EA%B0%81%EA%B0%81-%EC%96%B8%EC%A0%9C-%EC%93%B0%EB%8A%94%EA%B1%B4%EA%B0%80%EC%9A%94

		6.overide, overriding 차이점
		
		7.콘솔 쿼리로그 해결방법(logback.xml)
		logback.xml 에서 sql,resultset TRACE로 권한변경
		
		8.public static final
		값이 선언된 이후 변경할 수 없다.
	}
	
	public void xml(){
		
		--mybatis--
		1.쿼리
		
		1).parameterType 전달해줄 값의 타입
		2).resultType 반환받을 값의 타입
		
		//java call
		List list = fisDao.queryForList("SELECT_PORTAL_FIS_TRACKING_HTSV", paramMap);
		
		//select
		<select id="SELECT_PORTAL_FIS_TRACKING_HTSV" parameterType="java.util.HashMap" resultType="java.util.HashMap">
			//query
		</select>
		
		//java call
		fisDao.insert("INSERT_MDM_SHED_MGT", rowMap);
		
		//insert
		<insert id="INSERT_MDM_SHED_MGT" parameterType="java.util.HashMap">
			//query
		</insert>
		
		//java call
		fisDao.update("UPDATE_PORTAL_AIR_BKG_FILE_DOC", rowMap);
		
		//update
		<update id="UPDATE_PORTAL_AIR_BKG_FILE_DOC" parameterType="java.util.HashMap">
			//query
		</update>
		
		//java call
		fisDao.delete("DELETE_MDM_SHED_MGT", rowMap);
		
		<delete id="DELETE_MDM_SHED_MGT" parameterType="java.util.HashMap">
			//query
		</delete>
		
		//java Procedure call
		Map<String, Object> proParams = new HashMap<String, Object>();
        
	    proParams.put("I_CORP_CD", corpCd);
	    proParams.put("I_OFFICE_CD", officeCd);
	    proParams.put("I_MNGT_NO", fisUtils.checkNull(mainViewMap.get("MNGT_NO")));
	    proParams.put("I_CUST_CD", fisUtils.checkNull(custMap.get("EXEC_PART_CD")));
	    proParams.put("I_SELL_BUY_TYPE", "S");
	    proParams.put("I_REQ_SVC", fisUtils.checkNull(mainViewMap.get("REQ_SVC")));
	    proParams.put("I_MBL_HBL_TYPE", fisUtils.checkNull(mainViewMap.get("MBL_HBL_TYPE")));
	    proParams.put("I_LANGUAGE_CODE", langCd);
	    proParams.put("I_PROGRESS_GUID", "1");
	    proParams.put("I_REQUEST_USER_ID", userId);
        fisDao.queryForMap("hslp.fis.PROCD_SELL_TARIFF_FACTOR", proParams);
		
		//Procedure
		<resultMap id="tariffSellFactorMap" type="java.util.HashMap"></resultMap> //resultMap id 충돌주의
		<select id="PROCD_SELL_TARIFF_FACTOR" parameterType="java.util.HashMap" statementType="CALLABLE"> //프로시저 호출할때 statementType="CALLABLE" 사용해야함
			//query
		</select>
		
		2.주석 <!--  -->
		
		3.블럭
		
		<where>
			<if test='PAGE_SIZE != null and !PAGE_SIZE.equals("")'>
				//query
			</if>
		</where>
		
		1)if(단일조건),choose when otherwise(다중조건)
		2)choose, when, otherwise
		3)foreach
		
		4.파라메터
		#{OFFICE_CD} - 문자열
		${DYNAMIC_QUERY} - 쿼리
		CDATA 쿼리에 닫힘태그 있을경우 사용함
		<![CDATA[
		]]>
		
	}

}
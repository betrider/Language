-- 모두접기 Alt+0 / 모두펼치기 Alt+Shift+0 / 기호 양식순서 1. -> 1) -> (1)

CREATE OR REPLACE PROCEDURE ORACLE11G
(
      CUSTOM_NUMBER     IN  VARCHAR2
    , R_ERROR_CODE      OUT INTEGER
    , R_ERROR_MSG       OUT VARCHAR2
) AS

V_RTNCD         		VARCHAR2(20 CHAR)  := '';
V_RTNMSG        		VARCHAR2(500 CHAR) := '';
USER_CREATE_EXCEPTION   EXCEPTION;   

BEGIN
	
	BEGIN --1.command
	
		1.SELECT * FROM 테이블명 GROUP BY 컬럼명 ORDER BY 컬럼명
		2.INSERT INTO 테이블명 (컬럼명) VALUES (데이터)
		3.UPDATE 테이블명 SET 컬럼명 = 데이터 WHERE 컬럼 = 데이터
		4.DELETE 테이블명 WHERE 컬럼 = 데이터
		5.INSERT INTO 테이블명 SELECT * FROM 테이블명 -- INSERT-SELECT 형식 
		6.CREATE TABLE 테이블명 AS SELECT * FROM 테이블명 -- CREATE-SELECT 형식
		7.MERGE 형식 
		
		   MERGE INTO 테이블명
				USING (가상테이블 생성)
				   ON(테이블명.컬럼명 = 가상테이블명.컬럼명) --조건
		   WHEN MATCHED THEN
				   UPDATE SET 컬럼명 = 데이터
		   WHEN NOT MATCHED THEN
				   INSERT (컬럼명) VALUES (데이터)
		   ))) --보정
		8.WITH 형식 (
			WITH ALIAS명 AS ( SUB쿼리 ) , ALIAS명 AS ( SUB쿼리 )
			SELECT 컬럼명 FROM ALIAS명
		)
		9.JOIN 형식 (
			(1)암시적 조인 - SELECT * 
							   FROM FIRST_TABLE A1 
						 INNER JOIN SECOND_TABLE A2 --INNER JOIN
								 ON A1.NO1 = A2.NO1
						  LEFT JOIN SECOND_TABLE A2 --LEFT JOIN
								 ON A1.NO1 = A2.
						 RIGHT JOIN SECOND_TABLE A2 --RIGHT JOIN
								 ON A1.NO1 = A2.NO1
			(2)묵시적 조인 - SELECT * 
			                   FROM FIRST_TABLE A1, SECOND_TABLE A2 
							   WHERE A1.NO1    = A2.NO1    --INNER JOIN
							   WHERE A1.NO1(+) = A2.NO1    --LEFT OUTER JOIN
							   WHERE A1.NO1    = A2.NO1(+) --RIGHT OUTER JOIN
		)
		10.CASE WHEN 컬럼명 = 데이터 THEN 데이터 ELSE 데이터 END
		11.DECODE(원본데이터,비교데이터,TRUE값,FALSE값) --원본데이터 와 비교데이터 동일하면 TRUE값 반환 아닐경우 FALSE값 반환
		12.문자변환함수 ( 
			(1)REPLACE(원본데이터,비교데이터,변환데이터) --문자 묶음단위로 변환
				SELECT REPLACE('123456','345','666') FROM DUAL => '1236666'
			(2)TRANSLATE(원본데이터,비교데이터,변환데이터) --문자 한개단위로 변환
				SELECT REPLACE('123456','246','@$^') FROM DUAL => '1@3$5^'
		)
		13.NULL값 변환 (
			(1)NVL(데이터1,데이터2)           -- 데이터1이 NULL이면 데이터2 반환
			(2)NVL2(데이터1,데이터2,데이터3)  -- 데이터1이 NULL이 아니면 데이터2 반환 NULL이면 데이터3 반환
			(3)NULLIF(데이터1,데이터2)      -- 데이터1와 데이터2가 같으면 NULL반환 아닐경우에는 데이터1 반환
			(4)COALESCE(데이터,데이터.....) --NULL이 아닌 첫번째 값 반환
				SELECT COALESCE(NULL, NULL, 'third_value', 'fourth_value') => 'third_value'
		)
		14.문자열 자르기 (
			(1)SUBSTR --SUBSTR(데이터,시작위치,길이) CHAR기준
				SELECT SUBSTR('가나다라마',1,3) FROM DUAL => '가나다' 
			(2)SUBSTRB --SUBSTRB(데이터,시작위치,길이) BYTE기준
				SELECT SUBSTR('가나다라마',1,3) FROM DUAL => '가'    
		)
		15.문자열 길이체크 (
			(1)LENGTH : SELECT LENGTH('가나다') FROM DUAL => 3   --LENGTH(데이터) CHAR기준
			(2)LENGTHB : SELECT LENGTHB('가나다') FROM DUAL => 9 --LENGTHB(데이터) BYTE기준
		)
		16.변환함수(문자,숫자,날짜) (
			(1)TO_CHAR -- 숫자나 날짜를 문자열로 변환
				TO_CHAR(SYSDATE,'yyyy-mm-dd am hh24:mi:ss') => '2019-03-28 오후 15:38:05'
			(2)TO_NUMBER -- 문자를 숫자로 변환 
				SELECT TO_NUMBER('0123456789') FROM DUAL => 123456789
			(3)TO_DATE -- 문자를 날짜로 변환 
				TO_DATE('2019-03-28 14:47:01','YYYY-MM-DD hh24:MI:SS') => '2019-03-28 오후 2:47:01'
			(4)타임스탬프
				SELECT TO_CHAR(SYSTIMESTAMP, 'YYYYMMDDHH24MISSFF3') FROM DUAL
		)
		17.문자열 합치기 (
			(1)WM_CONCAT(컬럼명) --ORACLE 10G
			(2)LISTAGG(컬럼명,',') WITHIN GROUP(ORDER BY 컬럼명) -- ORACLE 11G
		)
		18.조건제어 (
			필드명 = 데이터
			필드명 LIKE (%데이터%)
			필드명 IN (데이터1,데이터2)
			필드명 IS NULL 
			필드명 IS NOT NULL
			EXISTS (SUB쿼리) : SELECT 1 FROM TABLE_NAME WHERE 컬럼명 = 데이터
		)
		19.부등호 : = 같다, <> or != 같지않다 
		20.한줄 띄우기 CHR(13)||CHR(10)
		21.대소문자 변환 UPPER , 소문자로 변환 LOWER , 첫글자 대문자 INITCAP
		22.공백 없애기 TRIM(양쪽),LTRIM(왼쪽),Rtrim(오른쪽)
		23.문자 채우기 LPAD('oracle',10,'x') => 'xxxxoracle' , RPAD('oracle',10,'x') => 'oraclexxxx'
		24.문자 거꾸로 출력 REVERSE(데이터)
		25.문자열 포함 INSTR(FILE_NM,'MyPhoto') 포함되면 0 반환 아니면 글자수 반환
		26.그룹함수 MAX(최대값),MIN(최소값),AVG(평균값),SUM(합계),COUNT(개수)
		27.집합연산자 UNION(중복제거O),UNION ALL(중복제거X),INTERSECT(교집합),MINUS(차집합) --INTERSECT 양쪽에 A,B데이터가 있는경우 , MINUS B에는 없고 A에는 있는 데이터
		28.순위결정함수 (
			(1)RANK       : RANK() OVER(ORDER BY 컬럼명 DESC) AS RANK                   -- (50,40,40,30,20) => 1,2,2,4,5
			(2)DENSE_RANK : ROW_NUMBER() OVER(ORDER BY 컬럼명 DESC) AS RANK             -- (50,40,40,30,20) => 1,2,2,3,4
			(3)ROW_NUMBER : RANK() OVER (PARTITION BY 컬럼명 ORDER BY 컬럼명 DESC) RANK -- (50,40,40,30,20) => 1,2,3,4,5
		)
		29.OVER함수 ( -- ORDER BY,GORUP BY 서브쿼리를 개선하기 위해 나온 함수. 서브쿼리라 그룹안에서 쓰려면 해당컬럼도 그룹바이에 추가해줘야 한다.
			COUNT(*)OVER() : 전체행 카운트
			COUNT(*)OVER(PARTITION BY 컬럼) : 그룹단위로 나누어 카운트

			MAX(컬럼)OVER() : 전체행 중에 최고값
			MAX(컬럼)OVER(PARTITION BY 컬럼) : 그룹내 최고값

			MIN(컬럼)OVER() : 전체행 중에 최소값
			MIN(컬럼)OVER(PARTITION BY 컬럼) : 그룹내 최소값

			SUM(컬럼)OVER() : 전체행 합
			SUM(컬럼)OVER(PARTITION BY 컬럼) : 그룹내 합

			AVG(컬럼)OVER() : 전체행 평균
			AVG(컬럼)OVER(PARTITION BY 컬럼) : 그룹내 평균

			STDDEV(컬럼)OVER() : 전체행 표준편차
			STDDEV(컬럼)OVER(PARTITION BY 컬럼) : 그룹내 표준편차
			
			OVER함수에서 사용되는 옵션
				1.PARTTITION BY
				2.ORDER BY DESC
				3.NULLS FIRST : NULL 데이터 먼저 출력.
				4.NULLS LAST : NULL데이터를 나중에 출력.
		)
		30.그룹함수 (
			참조:https://betrider.tistory.com/58
			(1)ROLLUP : SELECT COL1,COL2,SUM(COL3) FROM TABLE_NAME GROUP BY ROLLUP(COL1,COL2) --일반집계
			(2)CUBE   : SELECT COL1,COL2,SUM(COL3) FROM TABLE_NAME GROUP BY CUBE(COL1,COL2)   --다차원집계
			*GROUPING : (CASE WHEN GROUPING(COL1) = '1' THEN '합계' ELSE COL1 END)            --총계를 나타내는 결과물이면 1, 아니면 0을 반환한다.
 		)
		31.계층형쿼리 (
				SELECT LEVEL AS LEV
					 , A1.*
			 	 FROM 테이블명 A1
				WHERE 컬럼명 = 데이터                 --전체데이터 조건
		   START WITH 컬럼명 = 데이터                 --부모 노드 데이터 조건
		   CONNECT BY PRIOR 자식 컬럼명 = 부모 컬럼명 --데이터 연결시키기
		  ORDER SIBLINGS BY 컬럼명 ASC                --정렬
		  
			  SELECT ROWNUM 
				FROM DUAL 
		  CONNECT BY LEVEL < 3 => ROWNUM
									1
									2
									3
		)
		32.권한부여 (
			해당 계정으로 접속 또는 SYSTEM 계정으로 접속 후
			GRANT SELECT, INSERT, DELETE, UPDATE ON TABLE_NAME TO USER_NAME
		)
		33.소수점 포맷 SELECT TO_CHAR('12345.12345','FM999990.000') FROM DUAL => 12345.123
		34.디비링크,유저링크 : 디비링크명@유저링크.테이블명
		35.테이블 목록 보기 : SELECT * FROM TAB
		36.숫자함수 (
			(1)ROUND --반올림
				SELECT ROUND('12345.12345',-1) FROM DUAL => 12350
			(2)TRUNC --절삭
				SELECT TRUNC('12345.12345',-1) FROM DUAL => 12340
				or
				SELECT SYSDATE,							 => 2019-03-29 오후 5:37:41
					   TRUNC(SYSDATE, 'MI'),			 => 2019-03-29 오후 5:37:00
					   TRUNC(SYSDATE, 'HH24'),			 => 2019-03-29 오후 5:00:00
					   TRUNC(SYSDATE, 'DD')				 => 2019-03-29
					   TRUNC(SYSDATE),					 => 2019-03-29
					   TRUNC(SYSDATE, 'DAY'),			 => 2019-03-24
					   TRUNC(SYSDATE, 'MONTH'),		     => 2019-03-01
					   TRUNC(SYSDATE, 'YEAR'),			 => 2019-01-01
				  FROM DUAL
			(3)MOD --나머지
				SELECT MOD(15,10) FROM DUAL => 5
		)		
		37.테이블 항목 변경 ALTER (
			(1)ALTER TABLE을 이용한 COLUMN 추가
				ALTER TABLE 테이블명 ADD(컬럼명 데이터타입)
				ALTER TABLE 테이블명 ADD(컬럼명 데이터타입 default디폴트값)

			(2)ALTER TABLE을 이용한 COLUMN 변경
				ALTER TABLE 테이블명 MODIFY(컬럼명 데이터타입)

			(3)ALTER TABLE을 이용한 COLUMN 삭제
				LTER TABLE 테이블명 DROP(컬럼명 데이터타입)
		)
		38.테이블명 변경(RENAME) (
			ALTER TABLE 구테이블명 RENAME TO 신테이블명 
		)
		39.컬럼명 변경 (
			ALTER TABLE  LGD_COST_CHECK  RENAME COLUMN MODE1 TO MODE1
			ALTER TABLE  LGD_COST_CHECK  RENAME COLUMN MODE1 TO "MODE"
			(에러날때) 예약어를 넣고싶을때는 " " 으로 스트링처리를 해주면된다.
		)
	END
	
	BEGIN --2.toadShortCutKey
		
		F2 하단패널 ON/OFF
		SHIFT + F2 하단패털 꽉채우기
		F3 다음검색
		F4 & Ctrl+Click DESC
		F5,F9 실행
		F6 커서 에디터&패널 전환
		F7 화면클리어
		F8 쿼리 히스토리

		CTRL + F9 - 오류체크
		SHIFT + F9 - 커서위치 쿼리문 실행

		CTRL + U,L - 대문자,소문자전환
		CTRL + F - 검색
		CTRL + R - 문자변경
		CTRL + O - 파일열기
		CTRL + T , CTRL + . - 컬럼 OR 테이블리스트
		CTRL + B 주석
		CTRL + SHIFT + B 주석해제
		
		*CTRL + M - 쿼리 -> SQL문으로 변환

		SQL = " SELECT  "
		SQL = SQL & "OFFICE_CD, MNGT_NO, FARE_SEQ,  "
		SQL = SQL & "   DEL_HM "
		SQL = SQL & "FROM ELVIS_TEST.ACT_INV_DTL_DEL_LOG "
		
		CTRL + P - SQL문 ->쿼리로 변환
		CTRL + E Explain Plan(튜닝할때 사용)
		CTRL + Insert - Data Grid에서 값 복사할때 컬럼명도 복사
		CTRL+SHIFT+F 쿼리정렬 (원하는 범위 선택후 사용하면됨)

		*Data Grid에서 자료수정 (예제 테이블:FMS_HBL_MST)

		F11 디버깅

		SHIFT + F8 디버깅 한단계씩 진행

		View - Code Snippets 오라클 함수 목록

		*간단한 쿼리문 가지고 오기

		Schema Browser - 해당테이블 우클릭 - Generate Statement - Insert,Select,Update 중 클릭 후 붙여넣기
		
	END
	
	BEGIN --3.notePad
					
		=================== **select 문의 처리순서
		select 컬럼명 --(5)
		from 테이블명 --(1)
		where 조건절  --(2)
		//(1),(2)를 한 것은 해당 테이블에서 조건에 만족하는 행을 메모리(RAM)에 로드시킨것
		group by절 --(3)
		having 그룹함수 조건절 --(4)
		order by절 --(6)
		===================
		
		!!!데이터 그리드에서 바로 수정하기
			EDIT TABLE_NAME WHERE 컬럼명 = 데이터                      --전체컬럼
			or
			SELECT ROWID,A.* FROM TABLE_NAME A WHERE A.컬럼명 = 데이터 --일부컬럼 OR 전체컬럼
			
		!!!테이블명 검색 또는 컬럼명 검색 또는 인덱스 검색
			SELECT * FROM ALL_TAB_COLUMNS WHERE COLUMN_NAME = 데이터
			OR
			SELECT * FROM ALL_TAB_COLUMNS WHERE TABLE_NAME  = 데이터
			OR
			SELECT * FROM ALL_INDEXES WHERE INDEX_NAME  = 데이터

		!!!프로시저 내용 검색
			SELECT * FROM USER_SOURCE WHERE TYPE = 'PROCEDURE' AND TEXT LIKE '%데이터%'

		!!!함수 내용 검색
			SELECT * FROM USER_SOURCE WHERE TYPE = 'FUNCTION' AND TEXT LIKE '%데이터%'
			
		*IP확인
			select SYS_CONTEXT('USERENV', 'IP_ADDRESS', 15) ipaddr from dual
		
		*최신값 하나씩만 가지고오기
			SELECT * FROM (SELECT A.*,ROW_NUMBER()OVER(PARTITION BY COL1 ORDER BY COL2 DESC) RN FROM TABLE_NAME A) WHERE RN=1
			
		*파라메터 없으면 패스 있으면 조건 태우는 방법
			SELECT * FROM TABLE_NAME WHERE (PARAM1 IS NULL OR 컬럼명 = PARAM1)
		
		*합계와 총합계 같이표시
			SELECT DO_NO,DO_ITEM,SUM(DO_QTY),SUM(DO_QTY) OVER(PARTITION BY DO_NO) FROM FMS_DO_DTL GROUP BY DO_NO,DO_ITEM,DO_QTY
		
		*드랍 테이블 복구
			FLASHBACK TABLE FMS_HBL_OTH TO BEFORE DROP
			
		*IN 1000개 넘어갈때
			SELECT * FROM XXX WHERE ID IN (1,2,3,..) -> SELECT * FROM XXX WHERE (0,ID) IN ((0,1), (0,2), (0,3)..)
<<<<<<< HEAD
			  
=======
			 
>>>>>>> dfb4862d3dd8c867642b6f82d37e8175ed36f55a
		*계층형 쿼리 연결된값 전부 가져오기
			SELECT *
			  FROM ADT_CSY_MENU T1
			 WHERE APPCODE = 'C-PORTAL' AND MENUCODE LIKE 'PTL66%'
			 START WITH SUPERMENUCODE = '-1'
			CONNECT BY PRIOR MENUCODE = SUPERMENUCODE
			 ORDER SIBLINGS BY ORDERS ASC
			 
		*합계와 총합계 같이표시
			SELECT DO_NO,DO_ITEM,SUM(DO_QTY),SUM(DO_QTY) OVER(PARTITION BY DO_NO) FROM FMS_DO_DTL GROUP BY DO_NO,DO_ITEM,DO_QTY
		
		*디비복사
			(1)DB 언어확인 - select * from v$nls_parameters  //양쪽다 UTF8 맞는지 확인 필
			(2)DB 버전확인 - SELECT * FROM v$version // 
			(3)DB덤프뜰때 => database-export-export utility(user선택->next(static:None설정)->next->경로지정->확인) //백업
			(4)DB덤프받을때 => database-import-import utility(user선택->next->next->from~to 선택->확인)
			(5)Db데이터 날릴때는 전체 드래그해서 delete 하면됨 대신 DBLink ,Type은 지우면 안됨 Function 등은 지워도 괜찮음 
			(6)User계정 새로 추가해야됨(ELVIS_ICSK,ELVIS_ICSK)
			(7)DB링크는 안주우는게 나음 조심!!
			(8)ELVIS(ELVIS_SYS,ELVIS_SYS)->ELVIS_ICSK
			(9)Publish로 생성한 파일을 Webapp-WCF에다가 집어넣어줘야함
			(10)서버에 IIS설정해야됨
			(11)설정후 폴더안에다가 Webapp파일 통으로 넣으면된다.
			
		*테이블 데이터 확인
			SELECT (CASE WHEN COUNT (*) = 0 THEN 'N' ELSE 'Y' END) AS LINK_YN
			  FROM FMS_INV_DTL
			 WHERE REF_INV_NO = #{REF_INV_NO} AND REF_FARE_SEQ = #{REF_FARE_SEQ}
			 
		*메시지 확인
			DBMS_OUTPUT.PUT_LINE('Before DISABLE');
			
		*테이블 백업
			CREATE TABLE CO_CUSTOMER_20170224
			AS
			SELECT * FROM CO_CUSTOMER
			
		*oracle 덤프 빈테이블 안떠질때 
			ALTER SYSTEM SET DEFERRED_SEGMENT_CREATION=FALSE SCOPE=BOTH; 
			빈테이블일때 EXP 안된다. 위의명령어 실행. 
			그이후 만들어진 테이블에만 적용됨. 

		*ORACLE 덤프 설정변경
			SELECT 'ALTER TABLE '||table_name||' ALLOCATE EXTENT;' FROM user_tables WHERE segment_created = 'NO'; 
			해당계정으로 들어가서 실행하면 실행문이 나온다 이거 전체 결과 CTRL+C 해서 CTRL+V 해서 F5눌러서 해주면됨
			이걸로 테이블 변경하고 EXP 받으면 된다.
			
		*드랍테이블 복구 
			flashback table FMS_HBL_OTH to before drop;
			
		*원하는순서 ORDER BY
			CASE WHEN CODE = 'AAA' THEN '1' WHEN CODE = 'BBB' THEN '2' ELSE '3' END
			
		*IN NOT IN 둘다 사용 할 경우
			SELECT * 
			  FROM ACT_INV_DTL   
			 WHERE FARE_LOC_AMT > 0  
			   AND (FARE_CD IN ('POD','POD0') AND 1=@FARE_CD_01 ) --도착보고비 
				OR (FARE_CD IN ('SEC','SEC0') AND 1=@FARE_CD_02 ) --용역비  
				OR (FARE_CD NOT IN ('TRK','TRK0','WCC','RTK','RTK0','CCHG','WAT','PKC','PKC0','POD','POD0','SEC','SEC0') AND 1=@FARE_CD_03 )
			
			----------------------------오라클백업 명령어(데이터베이스)---------------------------------
		풀 백업 : EXP USERID=SYSTEM/ORA2764 full=y file=d:\BACKUP\ORA11_EXP_%D%.dmp log=d:\BACKUP\ORA11_log_%D%.log

		유저 백업(ELVIS_ABC) : EXP ELVIS_ABC/ELVIS_ABC FILE=E:\BACKUP_ABC\THU_EXP.DMP LOG=E:\BACKUP_ABC\THU_EXP.LOG
		유저 백업(MOBILE) : EXP MOBILE/MOBILE FILE=E:\BACKUP_ABC\THU_EXP.DMP LOG=E:\BACKUP_ABC\THU_EXP.LOG                
						
		--------------------------------오라클백업 명령어(클라이언트)---------------------------------

		[계정백업 EXPORT]
		exp 계정/아이디@tnsname owner=유저명 file=저장할 경로+파일명 log=저장할경로+파일명
		exp SYSTEM/ORA2764@ABC.ELVIS.COM owner=MOBILE file=D:backup_mobile_20180208.dmp log=D:backup_mobile_20180208.log
		또는
		exp MOBILE/MOBILE@ABC.ELVIS.COM file=D:backup_mobile_20180208.dmp log=D:backup_mobile_20180208.log

		[풀 EXPORT]
		exp SYSTEM/ORA2764@ABC.ELVIS.COM full=y file=D:backup_mobile_20180208.dmp log=D:backup_mobile_20180208.log
		or
		set D=%DATE:-=%
		exp system/yjit108@ICSK.ELVIS.COM full=y file=D:\backup_108full_%D%.dmp log=D:\backup_108full_%D%.log

		[계정백업 IMPORT] 
		imp 계정/아이디@tnsname file=저장할 경로+파일명 FROMUSER=export받은 유저명  TOUSER=import시킬 유저명 ignore=y log=저장할경로+파일명
		imp system/yjit108@ELVIS file=e:backup_ATLAS_20171227.DMP FROMUSER=ATLAS TOUSER=ATLAS ignore=y log=e:backup_ATLAS_20171227.log

		[전체백업]
		exp userid=system/manager file='C:\full.dmp' full=y
		imp userid=system/system file='C:\full.dmp' full=y 

		[사용자단위 백업]
		exp userid=scott/tiger file='C:\scott.dmp' 
		or
		exp userid=system/manager owner=scott file='C:\scott.dmp' 

		imp userid=system/manager owner=scott file='C:\scott.dmp' 
		
	END
	
	BEGIN --4.error
	
		*ORA-12899 
			DB링크로 INSERT할때 열에대한값이너무큼 오류나오면
			BACK 테이블로 CRATE TABLE SELECT 로 데이터 받은다음에 데이터만 다시 옮겨주자
			
		*ORA-01045
			GRANT CREATE SESSION TO 유저명
		
	END
	

EXCEPTION
	WHEN NO_DATA_FOUND THEN
           R_ERROR_CODE := -1;
		   R_ERROR_MSG := 'DATA NOT FOUND';
           RETURN;
	WHEN USER_CREATE_EXCEPTION THEN
           R_ERROR_CODE := -1;
           R_ERROR_MSG := V_RTNMSG;
           RETURN;
	WHEN OTHERS THEN
           R_ERROR_CODE := -1;
           R_ERROR_MSG := SQLERRM;
           RETURN;
END

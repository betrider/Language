#모두접기 Alt+0 / 모두펼치기 Alt+Shift+0 / 기호 양식순서 1. -> 1) -> (1)

Python3.6.7 (v3.6.7, Mar 2 28 2018, 15:00:15) [MSC v.1900 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.

>>> command()
>>> shortCutKey()
>>> notePad()
>>>







====================================================================================

import https://wikidocs.net/32 #내장함수
import https://hashcode.co.kr/code_runners #파이썬 코드실행기

class Python3:

	def command():
		
		1.산술연산자
			a + b      a와 b를 더함
			a - b       a에서 b를 뺌
			a * b      a에 b를 곱함
			a  /  b     a를 b로 나눔
			a // b     a를 b로 나눈 몫
			a % b     a를 b로 나눴을때의 나머지(mod)
			a ** b     a의 b제곱 
		2.논리연산자 
			a < b        a가 b보다 작으면 True를 반환함
			a > b        a가 b보다 크면 True
			a <= b      a가 b보다 작거나 같으면 True
			a >= b      a가 b보다 크거나 같으면 True
			a == b      a와 b가 같으면 True
			a  <> b      a와 b가 다르면 True   * 얘는 파이썬 3.x 버전에선 안됨
			a  != b       (위에꺼랑 같은 표현임)
			a and b     a와 b가 모두 참일 때만 True
			a  or  b      a와 b 중 하나라도 참이면 True
			not a         a가 False일때 True로 바꿔줌
			a in [a,b]   list 에 a가 포함되어 있으면 True
			'a' in 'abcd' 문자열 안에 'a' 라는 문자가 포함되어 있으면 True 
		3.대소문자 구분함(팁)
		4.문자열 ''묶어주기(팁)
		5.들여쓰기 Tab(팁)
		6.데이터 입력 
			사용자한테 데이터를 입력받을때 사용
			a,b = input('데이터입력'),input('데이터입력') 
		7.반복문 
			1)while
					while num > i:
							i+=1
							print(i)
							
			2)for
					for i in num:
						print(i)
						
			=num이 배열,문자열이면 안에있는 값을 순서대로 하나씩 가지고오는형식

					for i in range(1,10,1): - range(초기값,목표값,증가분)
						print(i)
						
					for i in range(10-1,-1,-1):
						print(i)
			=일반 형식

			for i in range(6):
					print(i)
			= 0~5까지 반복 
		8.조건문 
			1)if 조건문1:
						명령문1
						
			2)if 조건문1:
						명령문1
				else:
						명령문2
						
			3)if 조건문1:
						명령문1
				elif 조건문2:
						명령문2
				else 조건문3:
						명령문3 
		9.배열 
			*선언
			arr = [0 for i in range(5)] - arr[0]~arr[4] 까지 0 입력
			arr = [[0 for i in range(5)] for i in range(5)] - arr[0][0]~arr[4][4] 까지 0 입력

			1)1차원배열
				a = [1,2,3,4,5] 
				-> a[0] = 1
					 a[1] = 2
					 a[2] = 3
					 a[3] = 4 
					 a[4] = 5
					
			2)2차원배열
				a = [[1,2],[3,4],[5,6]]
				-> a[0][0] = 1
					 a[0][1] = 2
					 a[1][0] = 3
					 a[1][1] = 4
					 a[2][0] = 5
					 a[2][1] = 6 
		10.논리연산자 
			1 - true
			0 - false

			1 AND 1 = true
			1 AND 0 = false
			0 AND 1 = false
			0 AND 0 = false 

			1 OR 1 = true
			1 OR 0 = true
			0 OR 1 = true
			0 OR 0 = false

			1 XOR 1 = true
			1 XOR 0 = false
			0 XOR 1 = false
			0 XOR 0 = true

			not 1 = false
			not 0 = true
		11.진수 
			0진수 -> 2진수 bin(num)
			10진수 -> 8진수 oct(num)
			10진수 -> 16진수 hex(num)
		12.비트연산자 
			*2진수
			1)bin(0b0 & 0b1) -AND
			2)bin(0b0 | 0b1) -OR
			3)bin(0b0 ^ 0b1) -XOR
			4)bin(~0b1) -NOT

			True and True 일때만 True 나머지 False - And &
			False or False 일때만 False 나머지 True - OR |
			다를때 True 같을때 False - XOR ^
		13.함수 
			def 함수명(변수명):
			내용~
		14.format 
			temp_str = format(arr1[0]|arr2[0], str(n)+'b') - str(n) = 자리수 / b=2진수 o=8진수 x=16진수
		15.Call by value,Call by reference 
			일반 변수는 value
			배열은 reference로 사용가능
		16.제곱과 제곱근 
			1)제곱
			pow(2,4) 2^4 = 16
			2)제곱근
			import math
			math.sqrt(121) = 11.0
		18.배열에 추가하기 arr.append(string)
		19.배열 소문자로 변형 
			cities = ['A','B','C']
			1)소문자 : cities = [x.lower() for x in cities] - 'a','b','c'

			2)대문자 : cities = [x.upper() for x in cities] - 'A','B','C'
		20.배열 길이 - len 
			cities = ['A','B','C']
			len(cities) - 3
			*응용
			for i in range(len(rank)): - 배열 길이만큼 for문 돌리기
		21.원하는 문자 배열위치 - index 
			cities = ['A','B','C']
			cities.index('C') - 2
		22.배열에서 원하는 문자가 있는지 
			page = ['1','2','3']
			if '1' in page: - true
			if '4' in page: = false
		23.문자열 변경 replace 
			a = 'abcd'
			a.replace('a','c') -> 'cbcd'
		24.시간데이터 
			1)현재날짜데이터 가지고오기
			import datetime
			now = datetime.datetime.now() 
			now.year - 년
			now.month - 월
			now.day - 일
			now.hour - 시
			now.minute - 분
			now.second - 초

			2)원하는 날짜데이터 만들기
			from time import localtime,strftime
			datetime.datetime.strptime('문자열','추출값') 

			3)몇시간전 데이터 구하기 - timedelta
			now = datetime.datetime.now()
			now + datetime.timedelta(hours = 1)
			now + datetime.timedelta(seconds = 1)
			now + datetime.timedelta(microseconds = 1)

			ex)datetime.datetime.strptime('09:00','%H:%M')
			ex)datetime.datetime.strptime('2018/04/01 13:30:10.123','%Y/%m/%d %H:%M:%S.%f')
		25.두개의변수 교환 arr[1],arr[0] = arr[0],arr[1]
		26.형변환(정수,실수,문자형) 
			int(1.5) = 1
			float(5) = 5.0
			str(1) = '1'
		27.true & false ( 0 은 false , 나머지는 true )
		28.불러올때 (이름 Main 불러올때 - 변수 Main 함수 Main() 배열 Main[숫자] )
		29.*클래스
			1)인스턴스메서드(self 파라메터 필요)
			2)정적메서드(self 파라메터 필요없음) @staticmethod
			3)클래스메서드(cls 파라메터 필요) @classmethod

			예시
			class Rectangle:
				count = 0  # 클래스 변수(같이 공유함)
			 
				def __init__(self, width, height):
					self.width = width
					self.height = height
					Rectangle.count += 1
			 
				# 인스턴스 메서드
				def calcArea(self):
					area = self.width * self.height
					return area
			 
				# 정적 메서드
				@staticmethod
				def isSquare(rectWidth, rectHeight):
					return rectWidth == rectHeight   
			 
				# 클래스 메서드
				@classmethod
				def printCount(cls):
					print(cls.count)  
		30.매직메서드(참조:https://ziwon.github.io/posts/python_magic_methods/) 
		31.문자열 자르기[0:2]
			ex) time = '09:30'
			time[0:2] -> '09'
			time[3:5] -> '30'
		32.문자열 포맷 맞추기
			원본문자열.rjust(자리수, 원하는 문자열) -왼쪽으로 채우기
			원본문자열.ljust(자리수, 원하는 문자열) -오른쪽으로 채우기

			ex)"5".rjust(5, '0') -> '00005'
			   "5".ljust(5, '0') -> '50000'
		33.리스트 정렬
			timeTable = ["09:10", "09:09", "08:00"]
			timeTable = sorted(timeTable) -> ['08:00', '09:09', '09:10']

			sorted(문자열 & 배열) - 반환
			sorted(문자열 & 배열, reverse=True) - 반환
			.sort() - 변환
			.reverse() - 변환
		34.다중집합 - 복합자료형{} 중복허용안함
			s = {'a','b','c'}
			s = set('abc') => {'a','b','c'} -set만 나눠짐
			s = set({'abc'}) => {'abc'} -set만 통채로 넣고싶을때
			빈값 선언: s = set('')

			s.
			- add(x) : 집합에 원소 x를 추가한다.
			- clear() : 집합 내에 있는 데이터를 모두 지운다. (= 공집합으로 만든다.)
			- copy() : 집합을 복사한다.
			- intersection(S) : 다른 집합 S와의 교집합을 반환한다. (두 집합 모두 가지고 있는 원소를 반환한다.)
			- difference(S) : 다른 집합 S와의 차집합을 반환한다. (메소드를 사용한 집합만 가지고 있는 원소를 반환한다.)
			- union(S) : S집합과 합집합을 반환한다. (두 집합을 합친 원소들을 반환한다.)
			- discard(x) : 집합 내에 있는 원소 x를 삭제한다. (없는 데이터를 인자값으로 넣어도 에러가 발생하지 않는다.)
			- remove(x) : 집합 내에 있는 원소 x를 삭제한다. (없는 데이터를 인자값으로 넣으면 에러가 발생한다.)
			- pop() : 집합 내에 가장 앞에 있는 원소를 삭제하고 반환한다.
		35.리스트 교집합,합집합
			b1 = [1,2,3,4,5,9,11,15]
			b2 = [4,5,6,7,8]

			1)교집합 - intersection
			list(set(b1).intersection(b2))

			2)합집합
			list(set(b1).union(b2))
		36.알파벳 확인
			a = 'ab'
			a.isalpha() => true

			a = 'a+'
			a.isalpha() => false
		37.해시테이블
			import collections
			collect = collections.defaultdict(int)
			counts[letter] += 1

			for i in count.items() or count.values() or count.keys()

			ex)collect = defaultdict(<class 'int'>, {'AA': 3})
			'AA' in collect => true 
		38.Call by Value , Call by Reference
			따로 설정하는건 없고 값에따라 자동설정됨
			Call by Value
			일반변수,스태틱변수

			Call by Reference
			list(배열), dict(사전), set(다중집합) 와 같이 mutable object 가 인수로 전달되면 Call by Reference로 받음
		39.배열자르기
			arr = [1,2,3,4,5]
			형식:arr[:인덱스] or arr[인덱스:]

			arr[:인덱스] 인덱스까지 인덱스 포함안함
			arr[인덱스:] 인덱스부터 끝까지

			ex)arr[:2] = [1,2]
			   arr[2:] = [3,4,5]
		40.sum(합),max(최대값),min(최소값)
			sum(list)
			max(list)
			min(list)
		41.반올림,버림,내림,올림
			반올림 (round)
			올림 (math.ceil)1
			내림 (math.floor)
			버림 (math.trunc)

			0.5 반올림 함수
			import math
			def round2(number):
				if number+0.5 == math.ceil(number):
					return math.ceil(number)
				else:
					return round(number)
		42.절대값
			abs(변수)
		43.최대값(max값)
			import sys 
			sys.maxsize 
		44.배열 뒤집기
			list.reverse()
		45.문자열 포함
			S = 'abcd' 
			if 'a' in S: 
			'ok' 
		46.배열 최대값,최소값 인덱스
			list.index(max(list)) 
			list.index(min(list)) 
		47.아스키코드 변환
			문자열->아스키코드 : ord('Z') = 90 
			아스키코드->문자열 : chr(90) = Z 
	
	def shortCutKey():
		
	def notePad():
		


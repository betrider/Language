#������� Alt+0 / �����ġ�� Alt+Shift+0 / ��ȣ ��ļ��� 1. -> 1) -> (1)

Python3.6.7 (v3.6.7, Mar 2 28 2018, 15:00:15) [MSC v.1900 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.

>>> command()
>>> shortCutKey()
>>> notePad()
>>>







====================================================================================

import https://wikidocs.net/32 #�����Լ�
import https://hashcode.co.kr/code_runners #���̽� �ڵ�����

class Python3:

	def command():
		
		1.���������
			a + b      a�� b�� ����
			a - b       a���� b�� ��
			a * b      a�� b�� ����
			a  /  b     a�� b�� ����
			a // b     a�� b�� ���� ��
			a % b     a�� b�� ���������� ������(mod)
			a ** b     a�� b���� 
		2.���������� 
			a < b        a�� b���� ������ True�� ��ȯ��
			a > b        a�� b���� ũ�� True
			a <= b      a�� b���� �۰ų� ������ True
			a >= b      a�� b���� ũ�ų� ������ True
			a == b      a�� b�� ������ True
			a  <> b      a�� b�� �ٸ��� True   * ��� ���̽� 3.x �������� �ȵ�
			a  != b       (�������� ���� ǥ����)
			a and b     a�� b�� ��� ���� ���� True
			a  or  b      a�� b �� �ϳ��� ���̸� True
			not a         a�� False�϶� True�� �ٲ���
			a in [a,b]   list �� a�� ���ԵǾ� ������ True
			'a' in 'abcd' ���ڿ� �ȿ� 'a' ��� ���ڰ� ���ԵǾ� ������ True 
		3.��ҹ��� ������(��)
		4.���ڿ� ''�����ֱ�(��)
		5.�鿩���� Tab(��)
		6.������ �Է� 
			��������� �����͸� �Է¹����� ���
			a,b = input('�������Է�'),input('�������Է�') 
		7.�ݺ��� 
			1)while
					while num > i:
							i+=1
							print(i)
							
			2)for
					for i in num:
						print(i)
						
			=num�� �迭,���ڿ��̸� �ȿ��ִ� ���� ������� �ϳ��� ��������������

					for i in range(1,10,1): - range(�ʱⰪ,��ǥ��,������)
						print(i)
						
					for i in range(10-1,-1,-1):
						print(i)
			=�Ϲ� ����

			for i in range(6):
					print(i)
			= 0~5���� �ݺ� 
		8.���ǹ� 
			1)if ���ǹ�1:
						���ɹ�1
						
			2)if ���ǹ�1:
						���ɹ�1
				else:
						���ɹ�2
						
			3)if ���ǹ�1:
						���ɹ�1
				elif ���ǹ�2:
						���ɹ�2
				else ���ǹ�3:
						���ɹ�3 
		9.�迭 
			*����
			arr = [0 for i in range(5)] - arr[0]~arr[4] ���� 0 �Է�
			arr = [[0 for i in range(5)] for i in range(5)] - arr[0][0]~arr[4][4] ���� 0 �Է�

			1)1�����迭
				a = [1,2,3,4,5] 
				-> a[0] = 1
					 a[1] = 2
					 a[2] = 3
					 a[3] = 4 
					 a[4] = 5
					
			2)2�����迭
				a = [[1,2],[3,4],[5,6]]
				-> a[0][0] = 1
					 a[0][1] = 2
					 a[1][0] = 3
					 a[1][1] = 4
					 a[2][0] = 5
					 a[2][1] = 6 
		10.���������� 
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
		11.���� 
			0���� -> 2���� bin(num)
			10���� -> 8���� oct(num)
			10���� -> 16���� hex(num)
		12.��Ʈ������ 
			*2����
			1)bin(0b0 & 0b1) -AND
			2)bin(0b0 | 0b1) -OR
			3)bin(0b0 ^ 0b1) -XOR
			4)bin(~0b1) -NOT

			True and True �϶��� True ������ False - And &
			False or False �϶��� False ������ True - OR |
			�ٸ��� True ������ False - XOR ^
		13.�Լ� 
			def �Լ���(������):
			����~
		14.format 
			temp_str = format(arr1[0]|arr2[0], str(n)+'b') - str(n) = �ڸ��� / b=2���� o=8���� x=16����
		15.Call by value,Call by reference 
			�Ϲ� ������ value
			�迭�� reference�� ��밡��
		16.������ ������ 
			1)����
			pow(2,4) 2^4 = 16
			2)������
			import math
			math.sqrt(121) = 11.0
		18.�迭�� �߰��ϱ� arr.append(string)
		19.�迭 �ҹ��ڷ� ���� 
			cities = ['A','B','C']
			1)�ҹ��� : cities = [x.lower() for x in cities] - 'a','b','c'

			2)�빮�� : cities = [x.upper() for x in cities] - 'A','B','C'
		20.�迭 ���� - len 
			cities = ['A','B','C']
			len(cities) - 3
			*����
			for i in range(len(rank)): - �迭 ���̸�ŭ for�� ������
		21.���ϴ� ���� �迭��ġ - index 
			cities = ['A','B','C']
			cities.index('C') - 2
		22.�迭���� ���ϴ� ���ڰ� �ִ��� 
			page = ['1','2','3']
			if '1' in page: - true
			if '4' in page: = false
		23.���ڿ� ���� replace 
			a = 'abcd'
			a.replace('a','c') -> 'cbcd'
		24.�ð������� 
			1)���糯¥������ ����������
			import datetime
			now = datetime.datetime.now() 
			now.year - ��
			now.month - ��
			now.day - ��
			now.hour - ��
			now.minute - ��
			now.second - ��

			2)���ϴ� ��¥������ �����
			from time import localtime,strftime
			datetime.datetime.strptime('���ڿ�','���Ⱚ') 

			3)��ð��� ������ ���ϱ� - timedelta
			now = datetime.datetime.now()
			now + datetime.timedelta(hours = 1)
			now + datetime.timedelta(seconds = 1)
			now + datetime.timedelta(microseconds = 1)

			ex)datetime.datetime.strptime('09:00','%H:%M')
			ex)datetime.datetime.strptime('2018/04/01 13:30:10.123','%Y/%m/%d %H:%M:%S.%f')
		25.�ΰ��Ǻ��� ��ȯ arr[1],arr[0] = arr[0],arr[1]
		26.����ȯ(����,�Ǽ�,������) 
			int(1.5) = 1
			float(5) = 5.0
			str(1) = '1'
		27.true & false ( 0 �� false , �������� true )
		28.�ҷ��ö� (�̸� Main �ҷ��ö� - ���� Main �Լ� Main() �迭 Main[����] )
		29.*Ŭ����
			1)�ν��Ͻ��޼���(self �Ķ���� �ʿ�)
			2)�����޼���(self �Ķ���� �ʿ����) @staticmethod
			3)Ŭ�����޼���(cls �Ķ���� �ʿ�) @classmethod

			����
			class Rectangle:
				count = 0  # Ŭ���� ����(���� ������)
			 
				def __init__(self, width, height):
					self.width = width
					self.height = height
					Rectangle.count += 1
			 
				# �ν��Ͻ� �޼���
				def calcArea(self):
					area = self.width * self.height
					return area
			 
				# ���� �޼���
				@staticmethod
				def isSquare(rectWidth, rectHeight):
					return rectWidth == rectHeight   
			 
				# Ŭ���� �޼���
				@classmethod
				def printCount(cls):
					print(cls.count)  
		30.�����޼���(����:https://ziwon.github.io/posts/python_magic_methods/) 
		31.���ڿ� �ڸ���[0:2]
			ex) time = '09:30'
			time[0:2] -> '09'
			time[3:5] -> '30'
		32.���ڿ� ���� ���߱�
			�������ڿ�.rjust(�ڸ���, ���ϴ� ���ڿ�) -�������� ä���
			�������ڿ�.ljust(�ڸ���, ���ϴ� ���ڿ�) -���������� ä���

			ex)"5".rjust(5, '0') -> '00005'
			   "5".ljust(5, '0') -> '50000'
		33.����Ʈ ����
			timeTable = ["09:10", "09:09", "08:00"]
			timeTable = sorted(timeTable) -> ['08:00', '09:09', '09:10']

			sorted(���ڿ� & �迭) - ��ȯ
			sorted(���ڿ� & �迭, reverse=True) - ��ȯ
			.sort() - ��ȯ
			.reverse() - ��ȯ
		34.�������� - �����ڷ���{} �ߺ�������
			s = {'a','b','c'}
			s = set('abc') => {'a','b','c'} -set�� ������
			s = set({'abc'}) => {'abc'} -set�� ��ä�� �ְ�������
			�� ����: s = set('')

			s.
			- add(x) : ���տ� ���� x�� �߰��Ѵ�.
			- clear() : ���� ���� �ִ� �����͸� ��� �����. (= ���������� �����.)
			- copy() : ������ �����Ѵ�.
			- intersection(S) : �ٸ� ���� S���� �������� ��ȯ�Ѵ�. (�� ���� ��� ������ �ִ� ���Ҹ� ��ȯ�Ѵ�.)
			- difference(S) : �ٸ� ���� S���� �������� ��ȯ�Ѵ�. (�޼ҵ带 ����� ���ո� ������ �ִ� ���Ҹ� ��ȯ�Ѵ�.)
			- union(S) : S���հ� �������� ��ȯ�Ѵ�. (�� ������ ��ģ ���ҵ��� ��ȯ�Ѵ�.)
			- discard(x) : ���� ���� �ִ� ���� x�� �����Ѵ�. (���� �����͸� ���ڰ����� �־ ������ �߻����� �ʴ´�.)
			- remove(x) : ���� ���� �ִ� ���� x�� �����Ѵ�. (���� �����͸� ���ڰ����� ������ ������ �߻��Ѵ�.)
			- pop() : ���� ���� ���� �տ� �ִ� ���Ҹ� �����ϰ� ��ȯ�Ѵ�.
		35.����Ʈ ������,������
			b1 = [1,2,3,4,5,9,11,15]
			b2 = [4,5,6,7,8]

			1)������ - intersection
			list(set(b1).intersection(b2))

			2)������
			list(set(b1).union(b2))
		36.���ĺ� Ȯ��
			a = 'ab'
			a.isalpha() => true

			a = 'a+'
			a.isalpha() => false
		37.�ؽ����̺�
			import collections
			collect = collections.defaultdict(int)
			counts[letter] += 1

			for i in count.items() or count.values() or count.keys()

			ex)collect = defaultdict(<class 'int'>, {'AA': 3})
			'AA' in collect => true 
		38.Call by Value , Call by Reference
			���� �����ϴ°� ���� �������� �ڵ�������
			Call by Value
			�Ϲݺ���,����ƽ����

			Call by Reference
			list(�迭), dict(����), set(��������) �� ���� mutable object �� �μ��� ���޵Ǹ� Call by Reference�� ����
		39.�迭�ڸ���
			arr = [1,2,3,4,5]
			����:arr[:�ε���] or arr[�ε���:]

			arr[:�ε���] �ε������� �ε��� ���Ծ���
			arr[�ε���:] �ε������� ������

			ex)arr[:2] = [1,2]
			   arr[2:] = [3,4,5]
		40.sum(��),max(�ִ밪),min(�ּҰ�)
			sum(list)
			max(list)
			min(list)
		41.�ݿø�,����,����,�ø�
			�ݿø� (round)
			�ø� (math.ceil)1
			���� (math.floor)
			���� (math.trunc)

			0.5 �ݿø� �Լ�
			import math
			def round2(number):
				if number+0.5 == math.ceil(number):
					return math.ceil(number)
				else:
					return round(number)
		42.���밪
			abs(����)
		43.�ִ밪(max��)
			import sys 
			sys.maxsize 
		44.�迭 ������
			list.reverse()
		45.���ڿ� ����
			S = 'abcd' 
			if 'a' in S: 
			'ok' 
		46.�迭 �ִ밪,�ּҰ� �ε���
			list.index(max(list)) 
			list.index(min(list)) 
		47.�ƽ�Ű�ڵ� ��ȯ
			���ڿ�->�ƽ�Ű�ڵ� : ord('Z') = 90 
			�ƽ�Ű�ڵ�->���ڿ� : chr(90) = Z 
	
	def shortCutKey():
		
	def notePad():
		

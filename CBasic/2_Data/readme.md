# 데이터를 담는 변수와 상수

## 데이터 형식
- 기본 데이터 형식
  - 정수 형식 (char/uchar, signed byte/byte, short/ushort, int/uint)
    - u : 부호가 없다. (+/- 가 없다)
  - 부동 소수형식 (float, double)
- 복합 데이터 : 기본 데이터 형식을 조합한 데이터
  - 클래스, 구조체, 인터페이스

## 변수
- 데이터를 저장할 수 있는 메모리 공간
- 코드에서 이름(식별자)를 붙여 사용
  ex. int age = 33 : 해당 변수는 정수 형식을 갖는다.

## 스택 (Stack)
- 데이터를 쌓아 올리는 구조의 메모리
- **나중**에 쌓인 데이터를 **먼저** 제거
- **처음**에 쌓인 데이터를 **나중**에 제거
- 쌓인 순서의 역순으로 필요 없는 데이터를 자동으로 제거 (자동 메모리)

## 힙 (Heap)
- 자유롭게 데이터를 저장할 수 있는 메모리
- 별명 : 자유 저장소(Free Store)

## 값 형식 (Value Type)
- 메모리에 값을 담는 데이터 형식
- 스택에 할당 (즉, 자동으로 제거됨)
- 기본 데이터 형식과 구조체가 여기에 해당
  <img width="1477" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/563c742c-75bc-4860-95bb-dfce6c9118b4">
  <br>

## 참조 형식 (Reference Type)
- 메모리에 다른 변수의 주소를 담는 데이터 형식
- 힙에 할당 (가비지 콜렉터에 의해 제거됨)
- 복합 데이터 형식과 클래스 등이 여기에 할당
  <img width="1339" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/ea379294-55d8-4f40-b4a9-7897d41eb261">
  <br>

## 기본 데이터 형식
- C#이 제공하는 기본 데이터 형식
- 수 형식
  - 정수 형식 (int/uint, short/ushort, byte/sbyte ...)
  - 부동 소수점 형식 (float[4byte], double[8byte], decimal[16byte])
- 논리 형식(bool) : True/False
- 문자열 형식 (string)
- object 형식
- 복합 데이터 형식은 기본 데이터 형식을 바탕으로 만들어짐

## 박싱과 언박싱
- 박싱 : 값 형식을 object 형식에 담아 힙에 올리기
- 언박싱 : 힙에 올라가 있는 데이터를 object에서 꺼내 값 형식으로 옮기기
  <img width="758" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/d5b580a0-0ae6-4827-805f-6bf552accea0">
  <br>

## 상수
- 변수 : 변경이 가능한 수
- 상수 : 항상 최초의 상태를 유지하는 수
- const 키워드를 이용하여 선언
  ex) const int MAX_INT_BIT = 32;

## 열거 형식
- 하나의 이름 아래 묶인 상수들의 집합
- enum 키워드를 이용하여 선언
  ex. 아래 예시에서, YES는 0, NO는 1, CANCEL은 2, CONFIRM은 3, OK는 4로 자동 상수 할당됨, 중복을 피할 수 있음.
      사용시에는, DialogResult.YES; , DialogResult.NO; 형식으로 사용해주면 됨.
  <img width="1124" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/0e781fad-7dfe-4984-a142-10568875c5bf">
  <br>

## var 키워드
- var 키워드로 선언한 변수는 컴파일러가 리터럴을 분석하여 **자동으로 형식을 추론**함
- **지역 변수**에 대해서만 사용 가능 (메소드 안에서만 사용 가능, 클래스, 구조체에서는 사용 불가)
  ```
  var a = 3; //a는 int형식
  var b = "Hello"; //b는 str형식
  ```
  







  

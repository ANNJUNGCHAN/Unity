# 데이터를 가공하는 연산자

## 연산자란?
- 컴파일러에게 데이터 가공을 지시하는 기호 (+,-,=,!,&,|) 
- 종류 : 산술/관계/논리/비트/할당/기타...
  <img width="1225" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/ec9a7552-8cc0-4ab6-9d64-f108ec5b583c">
  <br>

## 산술 연산자
- 수치 형식의 데이터를 다루는 연산자
  (정수 형식과 부동 소수점 형식, Decimal 형식에 대해서만 사용 가능)
- 두 개의 피연산자가 필요한 이항 연산자 (Binary Operator)
  <img width="1222" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/558cb990-efd9-49e4-9706-92c9891f002d">
  <br>
  ```
  Console.WriteLine(3+4); // 7 출력

  int result = 15/3;
  Console.WriteLine(result); // 5 출력
  ```

## 증가 연산자와 감소 연산자
- 증가 연산자는 피연산자의 값을 1 증가
- 감소 연산자는 피연산자의 값을 1 감소
  <img width="1186" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/3de87ca9-aee2-4454-a7b5-ed378b77c46c">
  <br>
  ```
  int a = 10;
  a++; //a는 11
  a--; //a는 10 (11-1)
  ```
- 전위/후위 연산자의 차이
  - 증가 연산자
    ```
    int a = 10;
    Console.WriteLine(a++); //11이 아닌 10을 출력. 출력 후에 a는 11로 증가
    Console.WriteLine(++a); //12를 출력 (11+1=12)
    ```
  - 감소 연산자
    ```
    int a = 10;
    Console.WriteLine(a--); //9가 아닌, 10을 출력. 출력 후에는 a는 9로 감소
    Console.WriteLine(--a); //8을 출력 (9-1 = 8)
    ```

## 문자열 결합 연산자
```
int result = 123 + 456; //result는 579, 덧셈 연산자
string result = "123" + "456" //result는 "123456", 문자열 결합 연산자
```

## 관계 연산자
- 관계 연산자는 두 피연산자 사이의 관계를 확인하는 연산자
  <img width="1442" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/f395b6c4-47e9-45a9-a878-f640dacdfae1">
  <br>
  ```
  bool result;

  result = 3 > 4; // 거짓
  result = 3 >= 4; // 거짓
  result = 3 < 4; // 참
  result = 3 <= 4; // 참
  result = 3 == 4; // 거짓
  result = 3 != 4; // 참
  ```

## 논리 연산자
- 논리연산 : Bool 연산이라고 부르며, 참과 거짓의 진리값이 피연산자인 연산
- && : and
- || : or
- ! : not
  <img width="1112" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/3cdf8c5b-51d7-499f-b7dd-8cb7c5924495">
  ```
  int a = 3;
  int b = 4;
  bool c = a < b && b <5 // c는 True
  bool d = a > b && b <5 // d는 False
  bool e = a > b || b < 5 // e는 true
  bool f = !e //e의 부정은 False, f는 False
  ```

## 조건 연산자
- 조건에 따라 두 값중 하나의 값을 반환
- 사용 형식 : 조건식 ? 참일때의 값 : 거짓일 때의 값
  ```
  int a = 30 ;
  string result = a ==30 ? "삼십" : "삼십아님"; //result는 "삼십"
  ```

## 비트 연산자
- 비트 수준에서 데이터를 가공하는 연산자
  <img width="1480" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/dc47bfdd-95b7-4328-9b4f-bcf98b3985ec">
  <br>
  ```
  int a = 240 ; // 00000000 00000000 00000000 11110000
  int result_1 = a << 2 ; // 00000000 00000000 00000011 11000000
  int result_2 = a >> 2 ; // 00000000 00000000 00000000 00111100
  ```
  - int a = 240 << 2;
  <img width="1609" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/91cdb3ef-0c54-40c9-a44d-5694cbc15cab">
  <br>
  <img width="1454" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/0034326f-d14a-415f-af81-7e601d02793a">
  <br>
  <img width="1237" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/8a709a3d-d796-42e1-a581-bcaa1e590cc0">
  ```
  int a = 255 ;
  int result = ~a ; // result는 -256
  ```

## 할당 연산자
- 변수 또는 상수에 피연산자를 할당
  <img width="1399" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/49aee7a0-f180-4a11-8225-9aa801e0fbc2">

## 연산자의 우선 순위
<img width="1457" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/0ff84dc8-94da-4851-8b00-e9259adb3029">



  

  
  
  








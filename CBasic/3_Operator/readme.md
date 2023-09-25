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








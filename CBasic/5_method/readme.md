# 메소드로 코드 간추리기

## 메소드
- 일련의 코드를 하나의 이름 아래 묶은 것
- 묶은 코드는 메소드의 이름을 불러주는 것만으로 실행
- C/C++에서는 함수(Function), 파스칼에서는 프로시져(Procedure)등으로 불림

## 메소드 선언
- 클래스 내부에 선언
- 메소드 선언 필수 요소 3가지
  - 반환 형식
  - 메소드 이름
  - 매개변수 목록
- 결과를 반환할 때 return문 사용
```
class 클래스의_이름
{
  한정자 반환_형식 메소드의_이름 ( 매개_변수_목록 )
  {
    // 실행하고자 하는 코드 1
    // 실행하고자 하는 코드 2
    // ...
    // 실행하고자 하는 코드 n
    return 메소드의_결과
  }
}
```
```
// 메소드 선언
class Calculator
{
  public static int Plus (int a, int b)
  {
    Console.WriteLine("input : {0}, {1}", a, b);
    int result = a + b;
    return result;
  }
}
```



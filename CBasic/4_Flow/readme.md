# 흐름 제어

## 흐름 제어
- 코드의 실행 순서를 결정하는 것
  <img width="1462" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/da9549e4-a249-4699-9c16-f19d4eec6f77">

## 분기
- 제어 흐름을 여러 갈래로 나누는 것
- 단, 프로그램은 한번에 하나의 갈래만 실행할 수 있음
  <img width="1095" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/f90f5398-d31b-45c1-969e-a0d5f28d1ddc">

## if
- 조건을 만족하는 경우에만 분기 수행
- else if 절과 else 절은 옵션
  <img width="1549" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/96b8d5b5-4e24-46ae-b8b6-f6cc3b69225b">

## switch
- 입력식/값이 어떤 사례(case)와 매치되는지를 평가하여 분기 수행
- 분기 수행 후엔 break 문을 이용하여 switch문을 탈출
  <img width="1573" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/5d3ae07a-a67e-49c6-bae1-1b114b629403">

## 반복
- 특정 구간의 제어 흐름을 반복 실행
  <br>
  <img width="146" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/3abcebb1-aee0-4fa9-a562-5419f4914a6b">
  <br>

## while
- 조건을 만족하는 동안 반복 수행
  <br>
  <img width="662" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/d8900a59-c756-42a5-a111-2b871f286fcb">

## do while
- 코드 실행 후, 조건을 평가하여 반복 수행
  <br>
  <img width="761" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/ecc398c3-ed4e-40fd-97f0-9a8413083226">

## for
- 조건을 만족하는 동안 반복 수행
- (1) 조건 변수 초기화, (2) 조건 비교, (3) 조건변수 증/감
  <img width="895" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/23a0b184-a607-404d-bcd2-5e7eafb09bea">
  ```
  Console.WriteLine("A") ;
  for (int i = 0; i < 10; i++)
  {
    Console.WriteLine("B1");
    Console.WriteLine("B2");
  }
  Console.WriteLine("C");
  ```

## 점프
- 흐름을 특정 위치로 단번에 이동
- break, continue, goto, return, throw
  <br>
  <img width="130" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/973e1a1f-f90e-4636-96df-aa0c440c4bb8">
  <br>

## break
- break는 영어로 '탈출하다', '중단하다'라는 뜻
- 반복문이나 switch문의 실행을 중단
  <img width="742" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/81a058ca-098e-404e-a304-ce0bfc8ce358">

## continue
- 반복을 건너 뛰어 반복을 수행
  <img width="787" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/38616a2b-47b8-4033-89af-95d06910cd6c">

## goto
- 지정한 레이블로 제어를 이동
  <img width="764" alt="image" src="https://github.com/ANNJUNGCHAN/Unity/assets/89781598/083472b6-4fbb-4f1b-bf1c-09dd62f8df60">







  



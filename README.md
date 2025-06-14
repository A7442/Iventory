# 🧳 Unity Inventory System

간단한 장비 기반 인벤토리 시스템입니다. 플레이어는 아이템을 뽑고 장착/해제하며, 능력치 변화를 실시간으로 확인할 수 있습니다.

## 📦 프로젝트 구성

- Unity 기반 UI 인벤토리
- 무작위 아이템 뽑기 시스템
- 장비 장착 및 해제
- 능력치 실시간 반영
- 메인 메뉴 UI 전환
![image](https://github.com/user-attachments/assets/ab1d5837-5639-453e-8c45-ae49a18ba609)

---

## 🛠 주요 기능

### 🎲 무작위 아이템 뽑기
- 버튼 클릭으로 무작위 아이템 획득 (`RandomItem.cs`)
- 골드 100 사용 시 무작위 아이템 인벤토리에 추가됨

### 🧍 캐릭터 능력치 관리 (`Character.cs`)
- 공격력, 방어력, 체력, 치명타 능력치
- 장비 장착 시 능력치 상승, 해제 시 감소
- 골드 사용, 경험치 획득 및 레벨업 로직 포함
- ![image](https://github.com/user-attachments/assets/5f0b2e15-8cf2-4438-afdb-bcd4e9076111)


### 🎒 인벤토리 UI (`UIInventory.cs`)
- 24칸의 슬롯 UI 구성
- 아이템 장착/해제 버튼
- 현재 선택된 아이템 하이라이팅
- 장착된 아이템 표시 UI
- ![image](https://github.com/user-attachments/assets/e7a0a446-bf03-43a6-aa95-34773ddf7d9c)


### 👤 캐릭터 정보 UI (`UIMainMenu.cs`, `UIStatus.cs`)
- 메인 메뉴에서 캐릭터 이름, 직업, 설명, 레벨, 경험치, 골드 표시
- 능력치 패널을 통해 상세 정보 확인 가능
- ![image](https://github.com/user-attachments/assets/ad7ce719-b164-487d-81bd-a7b619deda54)



---

## 🧩 파일 설명

| 파일 | 설명 |
|------|------|
| `GameManager.cs` | 싱글톤 매니저, 캐릭터 초기화 |
| `Character.cs` | 캐릭터 정보 및 장비/경험치 관리 |
| `Item.cs` | 아이템 데이터 정의 (ScriptableObject) |
| `RandomItem.cs` | 무작위 아이템 뽑기 버튼 처리 |
| `UIInventory.cs` | 인벤토리 UI 제어 |
| `UISlot.cs` | 각 슬롯에 아이템 배치 및 장착 상태 표시 |
| `UIMainMenu.cs` | 메인 메뉴 UI 및 전환 |
| `UIStatus.cs` | 능력치 UI 표시 |

---

## 📌 사용법

1. 게임 시작 시 `GameManager`에서 캐릭터 초기화
2. `Draw` 버튼 클릭 시 아이템 획득
3. 인벤토리에서 아이템 클릭 → 장착 or 해제 버튼 선택
4. 장착 상태는 아이콘으로 표시되며 능력치는 즉시 반영됨
5. 메인 메뉴 버튼으로 `Status`와 `Inventory` 패널 간 전환

---

## 🎨 확장 아이디어

- 아이템 희귀도 추가
- 장착 제한 조건 (레벨, 직업 등)
- 저장/불러오기 기능
- 드래그 앤 드롭 구현

---

## 🔧 개발 환경

- Unity 2021.3.17f1
- C#

---

## 👤 개발자

- 작성자: 박준아
- 목적: Unity 학습 및 장비 시스템 프로토타입 구현

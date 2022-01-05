# Reversi_Algorithm
[제2회 알고리즘 대회] 오델로 게임(Reversi Game) 알고리즘

![012](https://user-images.githubusercontent.com/13028129/148027520-7f2085ac-3b4e-4d84-8c90-1f44d42333af.gif)


- 설명

	오델로 게임의 플레이 알고리즘 로직을 작성하여 상대편과 게임을 하여 3판 2승 먼저 승리하면 게임 오버 됩니다.
  
	참가자는 지정된 C#으로 작성된 DLL 파일을 참조해서 정해진 틀에 맞게 게임 플레이 로직을 기술 합니다.
	
	C# DLL을 참조해서 정해진 인터페이스를 상속받아 게임 알고리즘을 구현할 수 있습니다.
	
	제공되는 인터페이스 안에서 게임 플레이 로직 외 임의로 throw발생 등 고의적인 오류를 일으키거나, 방해 되는 요소가 있는 코드 제출시 주최자의 판단하에 거절될 수 있습니다.
	
	게임 알고리즘을 작성한 코드파일은 100% 전체 공개를 원칙으로 하며, 알고리즘 대회 주최자에게 전달합니다.
	
	알고리즘 소스코드 파일(.cs) 업로드 링크는 다음과 같습니다.
	
	https://arooong.synology.me:5001/sharing/oMFs2NhTB
  
- 규칙

	a. 8 X 8, 32 X 32 오델로 보드 사이즈로 진행 합니다.
	
	b. 오델로 게임의 기본 룰을 따릅니다.
	
	c. 8 X 8 사이즈 게임 진행으로 무승부시 32 X 32 사이즈로 다시 진행 합니다.
	
	d. 제일 먼저 흑돌에게 턴이 주어지고 번갈아 가면서 각 플레이어에게 한 턴씩 기회가 주어집니다.
	
	e. 플레이어 한 턴은 10초의 시간초과 가 있습니다. (※ 시간초과시 현재 이기고 있는 게임이라도 패배로 간주 합니다.)
	
	f. 유효하지 않은 좌표 선택시(놓을 수 없는 칸) 시간초과 10초 안에서는 다시 선택 하도록 Move()메서드가 호출됩니다.
	
	g. 돌을 놓을 수 있는 칸이 없다고 판단 되거나, 한턴 쉬는 경우 X = -1, Y = -1로 대입하는 경우 바로 다음 플레이어에게 턴이 돌아 갑니다.
	
	h. 참가자의 토너먼트 형식으로 진행합니다.
	
	i. 주어지는 인터페이스 dll은 기본 닷넷프레임워크 4.8 환경 AnyCPU, Release 구성으로 빌드 되어 제공 됩니다.
	
- 준비사항

	a. .NetFramework 4.8 이상 개발 가능 IDE프로그램
  
- 상금

	1등 : 치킨 기프티콘 (브랜드 미정)
	
	2등 : 카페 조각 케이크 기프티콘 (브랜드 미정)
	
	3등 : 커피 기프티콘 (브랜드, 커피 종류 미정)
  
  
- 알고리즘 대회에 도움을 주시는 분

	주최 : @arooong (구 닉네임 : 밍)
	
	기프티콘 후원 : 고요한 님

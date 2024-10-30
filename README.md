# 3D_Project
 ## 필수구현사항
 ### Unity
 - Input Action
    - Move : w (&uarr;), a (&larr;), s(&darr;), d(&rarr;)
    - Jump : Spacebar
    - Look : Delta[Mouse]
 ### C# Scripts
 - CharacterManager.cs
    - Monobehavuour 이해하기
    - 싱글톤 패턴 이해하기
        - CharacterManagerClass Instance 관리
    - 프로퍼티 이해하기
    - 역할 : 캐릭터 관리
 - PlayerController.cs
    - OnLookInput, OnJumpInput, OnMoveInput, ToggleCursor
        - InputAction.CallbackContext
    - 책임 : InputActionSystem 
 - Player.cs
    - private Awake()
        - 유니티가 어떻게 인식 할 수 있는지(Reflection, Monobehavuour)

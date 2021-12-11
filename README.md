# Minecraft for Windows 런처

이 런처는 마인크래프트 베드락 에디션(윈도우)의 버전을 선택하여 플레이할 수 있도록 해줍니다.

베타 버전과 정식 릴리즈 사이에서 왔다갔다할 때 유용합니다. 그동안 테스트 들어갔다 나오고, 지웠다 깔기 너무 어려웠잖아요?

## 주의
이 런처는 **복돌이 아닙니다.** 설치 과정에서 마인크래프트를 구매한 마이크로소프트 계정을 필요로 합니다.

## 사용 준비
- **Minecraft for Windows** 앱을 소유하고 있는 계정이 Microsoft Store에 로그인되어 있어야 합니다.
- **관리자 권한**으로 실행되어야 합니다.
- 설정 -> 업데이트 및 보안 -> 개발자용 -> **개발자 모드**가 활성화되어 있어야 합니다.
- 베타 버전을 사용하기 위해서는 **Xbox Inside Hub 앱에서 마인크래프트 베타 프로그램에 가입해야 합니다.**
- [Microsoft Visual C++ Redistributable](https://aka.ms/vs/16/release/vc_redist.x64.exe)이 설치되어 있어야 합니다.

## 설치
- [Releases](https://github.com/HURDOO/mc-w10-version-launcher/releases) 페이지에서 가장 최신 릴리즈를 다운받아 .zip 파일의 압축을 해제합니다.
- `MCLauncher.exe` 를 실행합니다.

## 자주 묻는 질문 (FAQ)
**마인크래프트를 동시에 여러 버전으로 실행할 수 있나요?**

적어도 지금은 지원되지 않습니다. 여러 버전을 동시에 _설치할_ 수는 있지만, 한번에 하나의 마인크래프트만 실행 가능합니다.

## Compiling the launcher yourself
You'll need Visual Studio with Windows 10 SDK version 10.0.17763 and .NET Framework 4.6.1 SDK installed. You can find these in the Visual Studio Installer if you don't have them out of the box.
The project should build out of the box with VS as long as you haven't done anything bizarre.

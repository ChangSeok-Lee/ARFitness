### ARFitness(2021_Capstone Design)
-----------------------
## 프로젝트 개요
웨이트 운동을 시작하고 싶지만 기구의 사용법을 모르는 초보자들을 위한 안드로이드 앱이다.  
모바일 기기의 카메라 화면으로 원하는 운동기구를 사용하는 애니메이션 동작을 확인할 수 있다.  
운동기구 사용 애니메이션은 AR컨텐츠로 제공된다.  
애플리케이션은 [Unity](https://unity.com/kr)로 구현하였으며, AR엔진은 [Vuforia](https://developer.vuforia.com/)를 이용한다.  
## 아키텍처
![arch](./img/arch.png)
## 개발 과정
1. UI제작 (4월 1주 ~ 4월 2주)  </br></br>
2. 마커등록 (4월 1주)
  - vuforia홈페이지 -> Develop 에서 데이터베이스 생성
  - License key를 가져와 unity 프로젝트에 등록
  - 마커로 사용할 이미지 다운로드
  - Target Manager에 이미지 등록
  - Database를 Unity에 import  </br></br>
3. 모션캡처 (4월 3주 ~ 5월 1주)
  - Kinect v2 depth카메라를 이용하여 촬영
  - ipi MocapStudio와 ipi Recoder사용(https://www.ipisoft.com/download/)
  ![mocap](./img/motioncap.png)  </br></br>
4. 애니메이션 데이터 보정 (4월 5주 ~ 5월 2주)  
  ![clib](./img/calibration.gif)  
5. Unity를 이용하여 app제작 (4월 1주 ~ 5월 4주)  
  <img src = "./img/play.jpg" width="30%"><img src = "./img/play2.jpg" width="30%">    </br></br>
6. 모델 텍스쳐 수정 (5월 2주 ~ 5월 3주)
  - 모델에 포함되어있는 텍스처 파일을 ProCreater를 이용하여 자극부위가 표시되도록 수정  </br></br>
7. 테스트 및 보정 (5월 4주 ~ 6월 1주)
## 기능 설명
- 운동기구의 마커를 인식한 후 표시되는 운동기구 이름을 터치하면 운동 종류를 선택할 수 있다.
- 운동 종류를 선택하면 해당 AR애니메이션이 재생된다.
- UI버튼들을 이용하여 애니메이션 제어 가능(일시정지, 재생, 다시보기)  
- 애니메이션을 드래그 하여 회전이 가능하다.

## 설치 방법
apk파일을 휴대폰에 저장한 후 파일 관리자를 이용하여 설치(ios 지원x)

## 사용 방법
- (저장위치)에 있는 마커 이미지를 프린트하여 원하는 위치에 배치시킨다.
- 앱 내 사용방법 화면 확인

## 참고
- 이 repository는 lfs를 사용합니다.
- repo를 clone할 때
  - git clone [url]
  - git lfs pull
- 100M이상 파일 올릴 때  
  - `git lfs install`  
  - `git lfs track "파일명.확장자"`  
  - `git add .gitattributes`  
  - 이후 기존 방식대로 커밋  

- 100M이상 커밋로그 제거
`java -jar bfg-x.xx.xx.jar --strip-blobs-bigger-than 100M`

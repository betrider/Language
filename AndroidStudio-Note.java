//#모두접기 Alt+0 / 모두펼치기 Alt+Shift+0 / 기호 양식순서 1. -> 1) -> (1)

package D:\개발노트\코드 
 
import http://codeasy.tistory.com/6 //쉽게배우는안드로이드

public class AndroidStudio {
	// 안드로이드 프로젝트는 app과 Gradle Scripts 로 이루어져 있다.
	// app은 manifests, java, res 패키지로 이루어져 있다.
	// manifests는 프로젝트 설정에 관한 부분, java는 프로그래밍 구현 부분, res는 레이아웃과 이미지, 문자열 리소스등 UI를 관장하는 부분이다.
	// 모든 안드로이드 프로젝트는 MainActivity를 기본적으로 갖고 있어야 하며 manifests/AndroidManifest.xml에서 설정해준다.
	// 화면을 만들때는 Activity파일(xxx,java파일)과 XML파일(xxxx.xml)을 쌍으로 만들어주고 Activity파일에서 XML파일을 연결해준다.
	// *IP 정보 변경 - API_Agent (D:\smartorder_sosx\smartorder-app\app\src\main\java\com\sosx\smartorder\util\API_Agent.java)
	public static void main(String[] args){
		
		andoridShortCutKey();
		notePad();
		
	}
	
	public void andoridShortCutKey(){
		
		shift + F9 : 디버그 실행
		F9 : 다음 중단점까지 진행
		F7 : 중단점의 메소드 속으로 들어가서 진행
		shift + F8 : 메소드 속에 들어갔던 진행에서 메소드를 빠져나옴
		F8 : 한줄씩 실행
		Alt + F9 : 커서를 원하는 라인에 놓고 누르면, 커서가 있는 곳까지 실행
		하지만 중간에 중단점이 있으면 중단점까지 실행
		Ctrl + Alt + F9 : 커서가 있는 위치까지 실행, 중간에 중단점이 있어도 무시
		Ctrl + Shift + F8 : 모든 중단점 위치 확인
		Ctrl + F2 : 디버그모드 종료. 일반 실행 모드로 전환
		Cnrl + [ 코드 처음으로 이동
		Ctrl + ] 코드 마지막으로 이동
		Ctrl + Alt + Shift+ F7 사용하는곳 찾기
		Ctrl + Alt + I 들여쓰기
		Ctrl + y 라인삭제
		Ctrl + / 한줄주석
		Ctrl+Shit+/ 블록주석
		Ctrl + F9 프로젝트 빌드
		Ctrl + F10 실행
		Ctrl + B 이동
		Ctrl + U 부모클랙스 이동
		Alt + Shit 위아래 코드이동(정렬)
		
	}

	public void notePad(){
		
		-----------------------------------------------스마트오더 설치자료

		-전송:PROC_MOBILE_CAMERA_SAVE
		-확인:PROC_MOBILE_ORQ0001_SAVE2
		-실행시 화면 splash->user_login ->Main->각화면
		
		*스마트오더 설치자료
		[ jdk-7u80-windows-x64]
		http://naver.me/FUWEWX4i 

		 

		[ apache-tomcat-7.0.62] 
		http://naver.me/5Swmwz5y 
		
		-------------------------------------------------
		
		컨트롤 삭제 이름하나 삭제

		**안드로이드 스튜디오 APK서명하는법(배포로 올릴때는 서명해서 올려야함)
		기존에 있을경우 불러오기해서 가지고오면됨

		-INTENT 데이터넣기-
		Intent popupIntent = new Intent(getApplicationContext(), Orq0001_popup_Activity.class); 
		popupIntent.putExtra("gubun", MainActivity.Event_cd_4);

		-INTENT 데이터빼기-
		Intent intent = getIntent();
		fordernm   = intent.getStringExtra("eventnm");

		-새화면 띄우기-
		Intent myIntent = new Intent(getApplicationContext(), Orq0001_Activity.class);
		startActivity(myIntent);

		-클릭 이벤트 생성-
		search_Button = (Button)findViewById(R.id.search_Button);
				search_Button.setOnClickListener(new OnClickListener(){
					public void onClick(View v) { 명령어 }
					
		&& = or
		|| = and
					
					
		

		*이미지

		b_icon256.png ->어플이미지
		splash.png ->로딩시 이미지
		login_title.png ->로그인화면 이미지
		main_img -> 메인이미지

		1)버전변경 APP-manifests-AndroidManifest.xml
		-버전 업그레이드 main\AndroidManifest.xml 에서 code 는 정수자리로 하나씩 증가시키고 버전 네임을 변경하면됨 1.1->1.2->2.0 등등 (세자리 까지 가능 1.0.0 -> 1.0.1)
		-버전바꿔서 apk 올리고 새로 올린버전이 (1.1 일경우) DB도 1.1로 바꿔준다 
		APP_COMMINFO에 NAME: 1.0->1.1 변경
		**versionName 전체검색 하면나옴

		**매니페스트 바꾸고 리빌드하고 빌드 앱해서 빌드된 apk 옮겨야됨

		**안드로이드 스튜디오 프로젝트명 변경
		C:\USERS\YJIT 이렇게 되있는 경로빼고 나머지는 다 바꾸면 된다. 
		app-java-com.xxxx.smartorder 부분은 폴더 경로 따라가서 폴더이름 변경하면됨


		2)안드로이드 이미지 변경 APP-manifests-AndroidManifest.xml


		--PDF->이미지 변환 사이트
		https://smallpdf.com/kr/pdf-to-jpg
		https://convertio.co/kr/image-converter/

		** 시간에 맞게 사진변경
		import android.os.Handler;


		mainimage	= (ImageView)findViewById(R.id.imageView1);

						mRunnable = new Runnable() {
							@Override
							public void run() {
								Tick++;
								int a = Tick % 3;
								if(a == 0)
								{
									mainimage.setBackgroundResource(R.drawable.main_img);
								}
								else if(a == 1)
								{
									mainimage.setBackgroundResource(R.drawable.main_img2);
								}
								else
								{
									mainimage.setBackgroundResource(R.drawable.main_img3);
								}
								mHandler.postDelayed(mRunnable, 5000); 5초후에 자신 다시호출
							}
						};

						mHandler = new Handler();
						mHandler.postDelayed(mRunnable, 5000); 5초후에 실행
		**

		**년월일 시분초 (오늘날짜 가지고오기)
		long now = System.currentTimeMillis();
						Date date = new Date(now);
						SimpleDateFormat sdf = new SimpleDateFormat("yyyyMMdd_HHmmss");
						String getTime = sdf.format(date);
						
						
		**카메라 결과값 받은후 bitmap 사진 파일에 넣어주기

		onActivityResult
		{
		itmap thumbnail = (Bitmap)data.getExtras().get("data");
		SaveBitmapToFileCache(thumbnail,Environment.getExternalStorageDirectory().getAbsolutePath().toString()+ "/DCIM/Camera/",getTime+".jpg"	);
		}


		// Bitmap to File
			public  void SaveBitmapToFileCache(Bitmap bitmap, String strFilePath,
											   String filename) {

				File file = new File(strFilePath);

				// If no folders
				if (!file.exists()) {
					file.mkdirs();
					// Toast.makeText(this, "Success", Toast.LENGTH_SHORT).show();
				}

				File fileCacheItem = new File(strFilePath + filename);
				OutputStream out = null;

				try {
					fileCacheItem.createNewFile();
					out = new FileOutputStream(fileCacheItem);
					bitmap.compress(Bitmap.CompressFormat.JPEG, 100, out);
				} catch (Exception e) {
					e.printStackTrace();
				} finally {
					try {
						out.close();
					} catch (IOException e) {
						e.printStackTrace();
					}
				}
			}
			
			
		** 안드로이드 스튜디오 EDI 전송
		String _Params = "";
							String _Uri = "";
							HttpURLConnection urlConnection = null;

							long now = System.currentTimeMillis();
							Date date = new Date(now);
							SimpleDateFormat sdf = new SimpleDateFormat("HH:mm:ss");
							String getTime = sdf.format(date);
							SimpleDateFormat sdf2 = new SimpleDateFormat("yyyyMMdd");
							String getDate = sdf2.format(date);

							_Params = "ORDER_NO=" + orderno + "&EDI_ORDER_NO=" + po_no + "&EIK_CLT_ID=" + "" + "&ITM_ID_CHG=" + "" + "&STOP_NUM=" + "" + "&R_CARNONUM=" + car_no + "&RINF_NAME=" + drv_nm + "&RINF_TEL=" + car_tel + "&To_TIME=" + getTime + "&REG_NAME=" + "" + "&T_DATE=" + getDate + "&GCLT_NAME=" + "" + "&UNLOAD_PIC_NM=" + "" + "&UNLOAD_HP=" + "";
							if(update_gubun.equals("01")){ //상차출발
								_Uri = "http://1.234.70.53:8080/ScheduledAppointment_3_1.asp";
							}else if(update_gubun.equals("03")){ //픽업도착
								_Uri = "http://1.234.70.53:8080/ActualAppointment_3_1.asp";
							}else if(update_gubun.equals("04")){ //픽업완료
								_Uri = "http://1.234.70.53:8080/ScheduledAppointment_3_2.asp";
							}else if(update_gubun.equals("06")){ //하차도착
								_Uri = "http://1.234.70.53:8080/ActualAppointment_3_2.asp";
							}
							URL url = new URL(_Uri+ "?" + _Params);
							urlConnection = (HttpURLConnection) url.openConnection();
							//urlConnection.setRequestMethod("GET");
							//urlConnection.connect();
							urlConnection.getResponseCode();
							
							/* // get the response code, returns 200 if it's OK
								int responseCode = connection.getResponseCode();
								if(responseCode == 200) {
									// response code is OK
									in = connection.getInputStream();
								}else{
									// response code is not OK */
		}


		**안드로이드 스튜디오 ORDER DETAIL
		하단에 나오는 부분 TOMCAT->SMARTORDER->ORDER.JSP 에 있다

		**Activity String 가지고오기
		customMemo.setText(R.string.close_string);

		**사진전송 500에러
		UTF8로 되어있는지 확인해야됨 안되어있으면 XML 다른이름저장해서 봐야됨

		**Language 언어 랭귀지 변환
		if (getString(R.string.Language).equals("ko")) {
								mWebView.loadUrl(API_Agent.API_SERVER_PROTOCOL+"://"+API_Agent.API_SERVER_URL+":"+API_Agent.API_SERVER_PORT+"/order.jsp?orderno="+orderno+"&compcd="+MainActivity.Compcd+"&userid="+MainActivity.userid+"&inv_no="+invno);
							}
							else if (getString(R.string.Language).equals("en")) {
								mWebView.loadUrl(API_Agent.API_SERVER_PROTOCOL+"://"+API_Agent.API_SERVER_URL+":"+API_Agent.API_SERVER_PORT+"/order_en.jsp?orderno="+orderno+"&compcd="+MainActivity.Compcd+"&userid="+MainActivity.userid+"&inv_no="+invno);
							}
							
		getString(R.string.Language).equals("ko")
							
		Integer.toString(R.string.Language).equals("ko")

		둘중 하나 사용하자.

		**사용자가 매핑한 구역이 열려 있는 상태인 파일에서 수행할 수 없습니다.

		1) 재부팅

		2) 클린->리빌드-> 빌드 apk

		**어플 실행시 DEBUG 계속 뜰 경우 (폰 껏다가 킨다)

		05-24 13:52:59.102 16189-16189/? I/zygote: Late-enabling -Xcheck:jni
		05-24 13:52:59.127 16189-16189/? W/zygote: Using default instruction set features for ARM CPU variant (cortex-a9) using conservative defaults
		05-24 13:52:59.148 16189-16197/? E/zygote: Failed sending reply to debugger: Broken pipe
		05-24 13:52:59.148 16189-16197/? I/zygote: Debugger is no longer active
		05-24 13:52:59.168 16189-16189/? W/ActivityThread: Application com.sosx.smartorder is waiting for the debugger on port 8100...
		05-24 13:52:59.182 16189-16189/? I/System.out: Sending WAIT chunk
		
	}
	
}

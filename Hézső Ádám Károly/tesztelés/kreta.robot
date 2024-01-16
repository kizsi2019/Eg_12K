*** Settings ***
Library           Selenium2Library
Library           Selenium2Library

*** Test Cases ***
belepes
    Open Browser \ \ \     https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253Duamx6lP2--XY9mGpF_XEmA0CDPUV4KupMx0dZHeNlPCL9gAW5fb0THzhy2GkToz_nGfMtWUUapvZVoNS4sylGldf8nHJHMI2DL0Nr3mbk0WLeAlyIHCCT8JfoBIfRGfK9_JnL0cX28VF3D7tI7Brcw%26response_mode%3Dform_post%26nonce%3D638361554269698192.YTE0NDI4YjAtOWIyMC00MTY5LWEwYWItNDVhYWIzYjg5MjI5ODYwNDMzZDUtYThlYi00M2E3LWIxNWEtZjZmZDljM2Q2N2My%26institute_code%3Dbmszc-egressy%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbmszc-egressy.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    Capture Page Screenshot
    Input Text \ \ \     //*[@id="UserName"]    72567442897
    Input Password \ \ \     //*[@id="Password"] \ \ \     2006-07-09
    Click Button \ \ \     //*[@id="submit-btn"]
    click button    /html/body/div/div[2]/div[1]/div[1]

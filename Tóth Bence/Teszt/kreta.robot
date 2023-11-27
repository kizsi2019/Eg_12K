*** Settings ***
Library           Selenium2Library

*** Test Cases ***
kreta
    open browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253Dx1frWNZ0QpFRcAOglx0S3RhNN_9q1-mRPZ19j4xsHs806AxHAOS8DvadzXfk6cgB_X1BHVkG1VXeIkyXLunRUmOuSxLeMGKZ01Sd7xYv3bU7rNQa945cNbjuf_OlOpYC7gxEvpV7HxdEPZTrhOZJOQ%26response_mode%3Dform_post%26nonce%3D638355514347922057.ZWM1YThiNjUtNTExMS00OWM1LWFiNzYtMjM2ODM1OTI3ZjMxMDQyY2M5YTEtN2Y2ZS00YTAwLThmMGQtZThmNDdlYzM0N2M3%26institute_code%3Dbmszc-egressy%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbmszc-egressy.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    edge
    input text    //*[@id="UserName"]    72376789688
    Input Password    //*[@id="Password"]    2003-06-25
    Click Button    //*[@id="submit-btn"]
    Click Button    //*[@class="Box-Item"]

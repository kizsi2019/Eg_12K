*** Settings ***
Library           Selenium2Library

*** Test Cases ***
Teszt1
    open browser    https://www.mikrosat.hu/    firefox
    click element    //*[@id="profile__btn"]/span
    input text    //*[@id="shop_user_login"]    asdasd@gmail.com
    input Password    //*[@id="shop_pass_login"]    asdasd
    click element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    close browser

Kreta
    open browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253DRE3KYE6d9IrsIrkV1CQN1GmcHsgr8NDvZulsPdKbk_B4DBwQX85Imsf7erxNNthoZDNmKMtL-nhDKW4eCs0sl8YV0VDqp7jl8ybwSQwDVgmswh6YNd4U1-feacdr6r6TXuoW-JQ0VU7dV_wSQZyPcg%26response_mode%3Dform_post%26nonce%3D638355515067767375.OTRhMzQ1ZjYtYzE2Ny00ODY5LWI0Y2QtMmUwZjY4MWIwNWM0NzI0MGU1YzEtZmQwYy00MzgyLWExMzItMmUzMjA1ZjI1OGM4%26institute_code%3Dbmszc-egressy%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbmszc-egressy.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox

    input text    //*[@id="UserName"]    72451999768
    input Password    //*[@id="Password"]    2004-07-08
    click element    //*[@id="submit-btn"]
    Capture Page Screenshot
    close browser

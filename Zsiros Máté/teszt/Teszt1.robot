*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open browser    https://www.microsat.hu    firefox
    capture page screenshot
    click element    //*[@id="profile__btn"]
    input text    //*[@id="shop_user_login"]    matezsi15@gmail.com
    input Password    //*[@id="shop_pass_login"]    gokart03ASD
    click Button    //*[contains(text(), "Belép")]
    wait until page contains    Belépve, mint    20s
    Capture page screenshot
    close browser

kreta
    open browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253Dj-hJMZVjlEbukyqLM0z1nra26eP06P1iePTWv7_GYS-j8Tuy0fPxkZOxLq9ck8k7zRJuv8V_gSLhjfgnT3NzDOQpxkmTczOKjqtSwaDAGceqe3L3SkF_eKmv3icTQWdTj4IIYH-Q7BrCeyzjDh9ZPQ%26response_mode%3Dform_post%26nonce%3D638355513047121979.YTQ2YTllMGUtY2MwZC00ZmEwLThkNTEtMzgwNjcwMTBjOTczNzcyNDM5ZTgtM2E0Yy00NDRkLTg0MTMtYTBkMWZhYjFhODAw%26institute_code%3Dbmszc-egressy%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbmszc-egressy.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    input text    //*[@id="UserName"]    72430440627
    input password    //*[@id="Password"]    2005-05-15
    click button    //*[@id="submit-btn"]

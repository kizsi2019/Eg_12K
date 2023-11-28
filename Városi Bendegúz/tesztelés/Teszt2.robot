*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt2
    Open Browser    https://www.mikrosat.hu    firefox
    Capture Page Screenshot
    Click Element     //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    valamivalami@gmail.com
    Input Password     //*[@id="shop_pass_login"]    alma12345
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
     Close Browser

Login test win10 Chrome 87
    Set Log Level    TRACE
     ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    87
    @{_tmp}    Create List     browserName: ${browser},    platform: Windows 10,    version: ${version},    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
     Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
     Click Element      //*[@id="profile__btn"]
    Input text      //*[@id="shop_user_login"]    valamivalami@gmail.com
    Input Password    //*[@id="shop_pass_login"]    alma12345
     Click Button    //*[contains(text(), "Belép")]
     Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Kréta
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253D5Bq9TxNRlpTukZQL9Orq7pT0lkONwBAbeVFZIUMNBBRsrlMkCXSTcxyv2OJpS-jIh0sIAakJWn9kOQHPhZgir4M534xGxLxGV4f1wbBZ0Ed2jRQLIdgnENXOR0uO3X6q-QlrRZsfv4kTRFVqX-lx6A%26response_mode%3Dform_post%26nonce%3D638355512775004433.MTZjNTUwZDQtZWNiMC00NWQyLThiOTgtNDI1MmUzZjIxYjhiY2IwY2VjODctMGYyMi00YWEyLWFlNGUtNGQ5NGY1OTRlM2Fh%26institute_code%3Dbmszc-egressy%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbmszc-egressy.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    Capture Page Screenshot
     Input Text    //*[@id="UserName"]    0
    Input Password    //*[@id="Password"]    0
    Click Button    //*[@id="submit-btn"]
    Capture Page Screenshot
    Wait Until Page Contains    Egressy
    Click Element    /html/body/div/div[2]/div[1]/div[1]/img




    Close Browser

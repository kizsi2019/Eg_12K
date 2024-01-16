*** Settings ***-
Library           Selenium2Library


*** Test Cases ***
teszteles
    open browser    https://www.mikrosat.hu    chrome
    click element    //*[@id="profile__btn"]
    Input Text    //*[@id="shop_user_login"]    kovacs.tibor19k@egressy.info
    input password    //*[@id="shop_pass_login"]    145cbc
    click button    //*[contains(text(), "Belép")]
    wait until page contains    Belépve, mint    20s
    Capture Page Screenshot
    close browser

loginteszt
    Set Log level    TRACE
    \ ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    87
    Create List    browserName: ${browser}    platform: Windows 10    version: ${version}    username: FelhasznaloNev    accessKey: HozzaferesiKulcs    name: TeszteljukLe    build: TeszteljukLe    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}

google login
    Open Browser    hhtps://alvizual.hu/kapcsolat/    firefox
    capture page screenshot
    input text    kovacs.tito@gmail.com
    input password    Yesmynamejeffxd2005
    click button    <button type="submit" class="auth_view--brandButton--K2XZu auth_view--brandButtonBase--yT1mh auth_branding--brand--aXUkB auth_view--fullWidth--HrOJA sign_in_and_up--primaryWideButton--Eh4W- auth_view--primaryWideButton--mkt6R auth_view--wideButton--1DF8U auth_view--fullWidth--HrOJA">Log in</button>

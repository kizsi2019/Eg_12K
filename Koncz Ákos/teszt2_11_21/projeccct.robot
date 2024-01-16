*** Settings ***
Library           Selenium2Library

*** Test Cases ***
chrome87teszt
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    87
    @{_tmp}    Create List    browserName: ${browser}, \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \     platform: Windows 10,    version: ${version},    username:FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}

    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    janko32323232@gmail.com
    Input Password    //*[@id="shop_pass_login"]    Akos1kiraly
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

teszt2
    Open Browser    https://www.mikrosat.hu    firefox
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    janko32323232@gmail.com
    Input Password    //*[@id="shop_pass_login"]    Akos1kiraly
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser






kretateszt
    Open browser

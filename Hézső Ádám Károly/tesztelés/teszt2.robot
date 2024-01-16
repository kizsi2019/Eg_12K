*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test2
    open browser    https://www.microsat.hu    firefox
    Capture Page Screenshot
    click element    //*[@id="profile__btn"]/span
    input text    //*[@id="shop_user_login"]    asdfgh@gmail.com
    input Password    //*[@id="shop_pass_login"]    asd123
    Click Button    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    close browser

Login Test Win10 Chrome 87
    Set Log level \ \ \     TRACE
     ${remote_url}=    Set variable \ \ \     https://ondemand.eu-central-1.saucelabs.com/wd/hub
     ${browser}=     Set variable \ \ \     Chrome
    ${version}= \ \ \     Set variable \ \ \     87
    @{_tmp}    Create List \ \ \     browserName: ${browser}, \ \     platform: Windows 10 , \ \     version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400,
    ${capabilities}= \ \ \     Set variable \ \ \      ${EMPTY.join(${_tmp})}

    Open browser \ \ \     https://www.mikrosat.hu \ \ \     browser=${browser} \ \ \     remote_url=${remote_url} \ \ \     desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element \ \ \     //*[@id="profile__btn"]
    Input text \ \ \     //*[@id="shop_user_login"] \ \ \     asdfgh@gmail.com
    Input Password \ \ \     //*[@id="shop_pass_login"] \ \ \     asd123
    Click Button \ \ \     //*[contains(text(), "Belép")]
    Wait Until Page Contains \ \ \     Belépve, mint \ \ \     20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 86
    Set Log level \ \ \     TRACE
     ${remote_url}=    Set variable \ \ \     https://ondemand.eu-central-1.saucelabs.com/wd/hub
     ${browser}=     Set variable \ \ \     Chrome
    ${version}= \ \ \     Set variable \ \ \     86
    @{_tmp}    Create List \ \ \     browserName: ${browser}, \ \     platform: Windows 10 , \ \     version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400,
    ${capabilities}= \ \ \     Set variable \ \ \      ${EMPTY.join(${_tmp})}

    Open browser \ \ \     https://www.mikrosat.hu \ \ \     browser=${browser} \ \ \     remote_url=${remote_url} \ \ \     desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element \ \ \     //*[@id="profile__btn"]
    Input text \ \ \     //*[@id="shop_user_login"] \ \ \     asdfgh@gmail.com
    Input Password \ \ \     //*[@id="shop_pass_login"] \ \ \     asd123
    Click Button \ \ \     //*[contains(text(), "Belép")]
    Wait Until Page Contains \ \ \     Belépve, mint \ \ \     20s
    Capture Page Screenshot
    Close Browser




Login Test Win10 Chrome 85
    Set Log level \ \ \     TRACE
     ${remote_url}=    Set variable \ \ \     https://ondemand.eu-central-1.saucelabs.com/wd/hub
     ${browser}=     Set variable \ \ \     Chrome
    ${version}= \ \ \     Set variable \ \ \     85
    @{_tmp}    Create List \ \ \     browserName: ${browser}, \ \     platform: Windows 10 , \ \     version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400,
    ${capabilities}= \ \ \     Set variable \ \ \      ${EMPTY.join(${_tmp})}

    Open browser \ \ \     https://www.mikrosat.hu \ \ \     browser=${browser} \ \ \     remote_url=${remote_url} \ \ \     desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element \ \ \     //*[@id="profile__btn"]
    Input text \ \ \     //*[@id="shop_user_login"] \ \ \     asdfgh@gmail.com
    Input Password \ \ \     //*[@id="shop_pass_login"] \ \ \     asd123
    Click Button \ \ \     //*[contains(text(), "Belép")]
    Wait Until Page Contains \ \ \     Belépve, mint \ \ \     20s
    Capture Page Screenshot
    Close Browser




Login Test Win10 Chrome 84
    Set Log level \ \ \     TRACE
     ${remote_url}=    Set variable \ \ \     https://ondemand.eu-central-1.saucelabs.com/wd/hub
     ${browser}=     Set variable \ \ \     Chrome
    ${version}= \ \ \     Set variable \ \ \     84
    @{_tmp}    Create List \ \ \     browserName: ${browser}, \ \     platform: Windows 10 , \ \     version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400,
    ${capabilities}= \ \ \     Set variable \ \ \      ${EMPTY.join(${_tmp})}

    Open browser \ \ \     https://www.mikrosat.hu \ \ \     browser=${browser} \ \ \     remote_url=${remote_url} \ \ \     desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element \ \ \     //*[@id="profile__btn"]
    Input text \ \ \     //*[@id="shop_user_login"] \ \ \     asdfgh@gmail.com
    Input Password \ \ \     //*[@id="shop_pass_login"] \ \ \     asd123
    Click Button \ \ \     //*[contains(text(), "Belép")]
    Wait Until Page Contains \ \ \     Belépve, mint \ \ \     20s
    Capture Page Screenshot
    Close Browser




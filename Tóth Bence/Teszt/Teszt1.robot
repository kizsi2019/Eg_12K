*** Settings ***
Library           Selenium2Library

*** Test Cases ***
Teszt1
    open browser    https://www.microsat.hu    edge
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    toth.bence18K@egressy.info
    Input Password    //*[@id="shop_pass_login"]    asd123
    Click Button    //*[contains(text(),'Belép')]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser



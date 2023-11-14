*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open Browser    https://www.mikrosat.hu/    firefox
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]/span
    Input text    //*[@id="shop_user_login"]    valamivalami@gmail.com
    Input Password    //*[@id="shop_pass_login"]    alma12345
    Click Button    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button
    Wait Until Page Contains    Belépve, mint:
    Capture Page Screenshot
    Close Browser




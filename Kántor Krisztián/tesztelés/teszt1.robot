*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test1
    open browser    https://www.microsat.hu    firefox
    Capture Page Screenshot
    click element    //*[@id="profile__btn"]/span
    input text    //*[@id="shop_user_login"]    asdasd@gmail.com
    input Password    //*[@id="shop_pass_login"]    asdika
    Click Button    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    close browser

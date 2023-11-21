*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszteles
    open browser    https://www.mikrosat.hu    chrome
    click element    //*[@id="profile__btn"]/span
    Input Text    //*[@id="shop_user_login"]    kovacs.tibor19k@egressy.info
    input password    //*[@id="shop_pass_login"]    145cbc
    click button    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button
    wait until page contains    Belepve, mint:    20s
    Capture Page Screenshot
    close browser

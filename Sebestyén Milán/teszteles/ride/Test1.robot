*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test1
    open browser    https://www.mikrosat.hu/    ff
    click element    //*[@id="profile__btn"]
    input text    //*[@id="shop_user_login"]    asdasd@gmail.com
    input password    //*[@id="shop_pass_login"]    asdasd
    click button    /html/body/div[8]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button
    close browser

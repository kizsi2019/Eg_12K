*** Settings ***
Library           Selenium2Library

*** Test Cases ***
KRETA_uzenet
    Open Browser    https://www.google.com    Chrome
    Input text    //*[@id="input"]    https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox
    Click element     /html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div/div
    Input text    //*[@id=":tg"]    kiss.zsigmond@egressy.info
    Input text    //*[@id=":pu"]    Tesztelés
    Input text    //*[@id=":r4"]    ...- .. ... ... --.. .- -... .- -
    Click element    //*[@id=":pk"]

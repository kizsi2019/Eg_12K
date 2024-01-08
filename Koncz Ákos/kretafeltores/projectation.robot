*** Settings ***
Library           Selenium2Library

*** Test Cases ***
kreta
    Open Browser    https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox    firefox
    Input Text    //*[@id="identifierId"]    koncz.akos20k@egressy.info
    Click Element    //*[@id="identifierNext"]/div/button/span
    Sleep 3s
    Input Text    //*[@id="password"]/div[1]/div/div[1]/input    jelszo
    Click Element    /*[@id="passwordNext"]/div/button
    Sleep 3s
    Click Element    /html/body/div[8]/div[3]/div/div[2]/div[2]/div[1]/div[1]/div/div
    Input Text    //*[@id=":sl"]    kiss.zsigmond@egressy.info
    Input Text    //*[@id=":oz"]    Teszt
    Input Text    //*[@id=":q8"]    Teszt
    Click Element    //*[@id=":op"]
    Close Browser

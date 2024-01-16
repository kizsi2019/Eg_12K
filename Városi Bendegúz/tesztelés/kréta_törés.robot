*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open Browser    https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox    firefox
    Capture Page Screenshot
    Input Text    //*[@id="identifierId"]    0
    Click Element    //*[@id="identifierNext"]/div/button/span
    Sleep    3s
    Input Text    //*[@id="password"]/div[1]/div/div[1]/input    0
    Click Element    //*[@id="passwordNext"]/div/button
    Sleep    3s
    Click Element    class="T-I T-I-KE L3"
    Input Text    //*[@id=":sl"]    kiss.zsigmond@egressy.info
    Input Text    //*[@id=":oz"]    Teszt
    Input Text    //*[@id=":q8"]    Ezzel az üzenettel jelzem, hogy sikeresen lezajlott a teszt! - Városi Bendegúz
    Click Element    //*[@id=":op"]
    Close Browser

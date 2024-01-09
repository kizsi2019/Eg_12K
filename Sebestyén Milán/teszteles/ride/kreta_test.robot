*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test
    open browser    https://mail.google.com/mail/u/0/#inbox    chrome
    input text    //*[@id="identifierId"]    sebestyen.milan19k@egressy.info
    click element    //*[@type="button"]
    input password    /html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input    Sebimilan2005

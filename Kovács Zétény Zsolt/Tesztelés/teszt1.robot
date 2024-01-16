*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open browser    https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ifkv=ASKXGp167EZT63iTM366yX6NzLsNQyMVwLxFNe57tGZKjJl4OM7_OSNDG0o5e64CXkSkzCNT-_-tHw&rip=1&sacu=1&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S1980306630%3A1701160713905030&theme=glif    firefox
    Input text    //*[@id="identifierId"]    kovacs.zeteny19k@egressy.info
    Input text



    capture page screenshot
    close browser

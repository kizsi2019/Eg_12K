*** Settings ***
Library           Selenium2Library

*** Test Cases ***
kreta
    open browser    https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&emr=1&ifkv=ASKXGp1B59J2vfxN0Eg3TLI1NAelk8JRtCOAnlAB2P2R3bv-yo2F_2zKmTNUxGKlomxqBUf0TRNp6g&ltmpl=default&ltmplcache=2&osid=1&passive=true&rm=false&scc=1&service=mail&ss=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-955921392%3A1701160400485063&theme=glif    edge
    input text    //*[@id="identifierId"]    zsiros.mate19k@egressy.info
    click button    Tovább
    wait until page contains    Adja meg jelszavát
    input text    //*[@id="identifierId"]    gokart03L
    click button    Tovább



kreta2
    open browser    https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&emr=1&ifkv=ASKXGp1B59J2vfxN0Eg3TLI1NAelk8JRtCOAnlAB2P2R3bv-yo2F_2zKmTNUxGKlomxqBUf0TRNp6g&ltmpl=default&ltmplcache=2&osid=1&passive=true&rm=false&scc=1&service=mail&ss=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-955921392%3A1701160400485063&theme=glif    edge
    input text    //*[@id="identifierId"]    zsiros.mate19k@egressy.info
    click button    Tovább
    wait until page contains    Adja meg jelszavát
    input text    //*[@id="identifierId"]    gokart03L
    click button    Tovább

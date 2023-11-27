*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    open browser    https://www.egressy.info/    firefox
    click element    //*[@id="FoNavJobb"]/a[2]
    Input text    <input placeholder="Felhasználónév" autofocus="" type="text" data-val="true" data-val-length="UsernameMaxLength" data-val-length-max="256" id="UserName" maxlength="256" name="UserName" value="" class="form-control">    72508092610
    Input password    //*[@id="Password"]    2004-09-06
    Click button    //*[@id="submit-btn"]
    Wait Until Page Contains    belépve, mint    20s
    Capture Page Screenshot
    Close browser

*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test1
    Open Browser    https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&emr=1&ifkv=ASKXGp2xp9a_gRFqit2fPkekoMdExvUWIN0ZMERx5WSdOCjU3w4V39dfIbzOx8uMuCgjMs3aBkfgNw&ltmpl=default&ltmplcache=2&osid=1&passive=true&rm=false&scc=1&service=mail&ss=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-754756799%3A1701161937905085&theme=glif    firefox
    Capture Page Screenshot
    Input Text    //*[@id="identifierId"]    hezso.adam19k@@egressy.info
    Click Button    //*[@id="identifierNext"]/div/button
    Wait Until Page Does Not Contain Element    //*[@id="identifierNext"]/div/button
    Input Password    //*[@id="password"]/div[1]/div/div[1]/input
    Click Button    //*[@id="passwordNext"]/div/button
    click link    /html/body/div[8]/div[3]/div/div[2]/div[2]/div[1]/div[1]/div/div
    Capture Page Screenshot
    close browser

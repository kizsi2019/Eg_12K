*** Settings ***
Library           Selenium2Library

*** Test Cases ***
kreta
    open browser    https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&emr=1&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&ifkv=ASKXGp3uE0u6UfY9ZInvpvFIFv00vtCSu63c2Bew-DmXDovJt97xZoUd7kGqX8d9xts3OBs3sS2Ozw&osid=1&passive=1209600&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S1477112814%3A1701160362981665&theme=glif    edge
    input text    //*[@id="identifierId"]    toth.bence18K@egressy.info
    Click Button    Tovább
    Wait until page does not contain element    //*[@id="identifierId"]
    Input Password    //*[@id="password"]    macilaci10
    Click Button    //*[@id="submit-btn"]
    Click Button    //*[@id="text"]

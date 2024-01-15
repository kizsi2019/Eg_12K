*** Settings ***
Library           Selenium2Library

*** Test Cases ***
Login Test
    Open Browser    https://accounts.google.com/InteractiveLogin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&emr=1&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&osid=1&passive=1209600&service=mail&ifkv=ASKXGp0LO9mPEFR467IUORijcfR8vikFniiPEG7I3dDVkdNOZCZ8kogw49Gy0NXOQQApJbN-Ix9esw&theme=glif&flowName=GlifWebSignIn&flowEntry=ServiceLogin    firefox
    Input text    //*[@type="email"]    onodi.kiss.viktor19k@egressy.info
    Click Element    //*[@id="identifierNext"]
    Sleep    5s
    Input text    //*[@type="password"]    B!k@OO88
    Click Element    //*[@id="passwordNext"]
    Sleep    5s
    Click Element    //*[@class="T-I T-I-KE L3"]
    Sleep    5s
    Input text    //*[@class="agP aFw"]    kiss.zsigmond@egressy.info
    Input text    //*[@name="subjectbox"]    orai
    Input text    //*[@class="Am aiL Al editable LW-avf tS-tW"]    Órai
    Click Element    //*[@class="T-I J-J5-Ji aoO v7 T-I-atl L3"]
    Sleep    5s
    Capture Page Screenshot
    Close Browser

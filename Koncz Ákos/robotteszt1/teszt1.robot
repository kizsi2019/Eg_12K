*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open browser    https://www.microsat.hu    firefox
    Click Element    //*[@id="profile__btn"]
    Input Text    //*[@id="shop_user_login"]    janko32323232@gmail.com
    Input Password    //*[@id="shop_pass_login"]    Akos1kiraly
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture page screenshot
    Close Browser

kretateszt
    Open browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fresponse_type%3Dcode%26client_id%3Dkreta-dkttanulo-js-web%26state%3DLnc5NlFJT2RvNEQxUW5MaC1FVnMyOGlycXF-bkttejBROGktSWFrWmFfNnlU%26redirect_uri%3Dhttps%253A%252F%252Fdkttanulo.e-kreta.hu%26scope%3Dkreta-dkt-webapi.public%2520openid%2520kreta-global-tananyagtar-webapi.public%2520kreta-elearning-webapi.public%2520kreta-fileservice-webapi.public%26code_challenge%3DnOlTIqlfVtd4peGAVpWXC5cot2dbmr-0biUExhd9n3Q%26code_challenge_method%3DS256%26nonce%3DLnc5NlFJT2RvNEQxUW5MaC1FVnMyOGlycXF-bkttejBROGktSWFrWmFfNnlU#    firefox
    input text    //*[@id="UserName"]    72580997815
    input text    //*[@id="Password"]    2005-11-03
    input text    //*[@id="login-institute-autocomplete"]/input[1]    Budapesti Műszaki SZC Egressy Gábor Két Tanítási Nyelvű Technikum (bmszc-egressy - 203058/005)
    click element    //*[@id="submit-btn"]
    Capture page screenshot
    close browser

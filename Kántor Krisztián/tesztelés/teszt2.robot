*** Settings ***
Library           Selenium2Library

*** Test Cases ***
test2
    open browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253DjdI6sncNcJYc7TUVcIBkp9-M61PYFAgItSe3ciOQlFvZXcdrlx-wB2w2Iv2OQzl6wcSexXbRcl_TRkoLgSdbPvIQxFyKjks7YJLog47ebTvfknDnoeXr-kClgqsf0-imiYGDp3iUJg9poVl4BEd1wg%26response_mode%3Dform_post%26nonce%3D638355513024034350.YzllMjg0ZDctOTE3Yi00YTYwLTgzNjQtNjk0Y2Y4ZGU4ZTQ5MDRkYjhmOWUtM2EwYS00YmUwLWIxY2UtMjk1Mzk4MzNkM2Iz%26institute_code%3Dbmszc-egressy%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbmszc-egressy.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    input text    //*[@id="UserName"]
    input password    //*[@id="Password"]
    click button    //*[@id="submit-btn"]
    wait until page contains    /html/body/div/div[1]/div[2]/div[1]

    capture page screenshot
    close browser

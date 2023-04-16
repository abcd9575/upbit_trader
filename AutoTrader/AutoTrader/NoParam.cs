using RestSharp;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrader.AutoTrader
{
    public class NoParam
    {
            private string upbitAccessKey;
            private string upbitSecretKey;

            private DateTime dt_1970_01_01;   //timestamp를 계산하기 위한 변수
            private const string baseUrl = "https://api.upbit.com";


            public NoParam(string upbitAccessKey, string upbitSecretKey)
            {
                //APIClass에서 받은 키를 입력
                this.upbitAccessKey = upbitAccessKey;
                this.upbitSecretKey = upbitSecretKey;

                this.dt_1970_01_01 = new DateTime(1970, 01, 01);
            }

        internal string Get(string v, object gET)
        {
            throw new NotImplementedException();
        }

        public string Get(string path, Method method)
            {

                var tokenSb = JWT_NoParam();
                var token = tokenSb.ToString();

                tokenSb.Clear();
                tokenSb = null;

                var client = new RestClient(baseUrl);       // RestSharp 클라이언트 생성
                var request = new RestRequest(path, method);
                request.AddHeader("Content-Type", "application/json"); // 컨텐츠 타입이 json이라고 서버측에 알려줌
                request.AddHeader("Authorization", token); // 인증을 위해 JWT토큰을 넘겨줌

                token = null;

                var response = client.Execute(request); // 요청을 서버측에 보내 응답을 받음

                try
                {
                    if (response.IsSuccessful)
                    { // 응답을 받는데 성공한 경우
                        return response.Content;  // 응답받은 요청정보를 string형태로 넘겨준다.
                    }
                    else
                    {
                        return null; // 응답을 받는데 실패시 null값을 반환
                    }
                }
                catch
                {
                    return null; // 오류시 null값을 반환
                }
            }


            public StringBuilder JWT_NoParam()
            {
                // 이 소스는 
                // https://docs.upbit.com/docs
                // 위 링크의 TABLE OF CONTENTS 에서
                // 가져왔습니다.
                TimeSpan diff = DateTime.Now - dt_1970_01_01;
                var nonce = Convert.ToInt64(diff.TotalMilliseconds);
                var payload = new JwtPayload {
                { "access_key", this.upbitAccessKey },
                { "nonce",  nonce  }
            };

                byte[] keyBytes = Encoding.Default.GetBytes(this.upbitSecretKey);
                var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(keyBytes);
                var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, "HS256"); // HMAC SHA256 방식의 줄임말
                var header = new JwtHeader(credentials);
                var secToken = new JwtSecurityToken(header, payload);

                var jwtToken = new JwtSecurityTokenHandler().WriteToken(secToken);

                StringBuilder returnStr = new StringBuilder();
                returnStr.Append("Bearer "); // 띄어쓰기 한칸 있어야함 주의!
                returnStr.Append(jwtToken);

                return returnStr;
            }
    }
}



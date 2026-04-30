namespace AISGorod.AspNetCore.Authentication.Esia;

/// <summary>
/// Сертификаты тестовой и продуктивной сред ЕСИА, используемые для формирования электронных подписей ответов как поставщика.
/// Можно взять из архива http://esia.gosuslugi.ru/public/esia.zip.
/// Ссылка на архив взята из методических рекомендаций ЕСИА, п. 3.1.2 "Аутентификация с использованием OpenID Connect 1.0".
/// </summary>
internal static class EsiaCertificates
{
    /// <summary>
    /// Сертификат тестовой среды ЕСИА.
    /// </summary>
    public const string TestCertificate = @"-----BEGIN CERTIFICATE-----
MIIDGjCCAgKgAwIBAgIEZrHvUjANBgkqhkiG9w0BAQsFADAeMQswCQYDVQQGEwJS
VTEPMA0GA1UECwwGUlRMYWJzMB4XDTI0MDgwNjA5MzkzMFoXDTM0MDgwNjA5Mzkz
MFowHjELMAkGA1UEBhMCUlUxDzANBgNVBAsMBlJUTGFiczCCASIwDQYJKoZIhvcN
AQEBBQADggEPADCCAQoCggEBAL77jUBqvXnVEBiqFzgjvM5AY0VHRfUQkHyuRVws
4fxD6LV8GmxaBOMUN8D/grjhbfcUoQ86G+7q9QOsSaIYGVPa9A0szKlSUGiGXJ8T
mvekIgdv0v4DoNrWe9OTdWKt9hWntZGNqwYXFIjMZsIyCrOFwslWXcbvBlh5dQZ0
IBZC4ybwbLXTssHz73oJEnk2d2Nwf80iRRwOawNbZid3Z0JMuq/8d3NuRsjZ/t8Z
7YOQ4Z3aaiyZlQr2XmzpZX0aXCXVGlbJPtifjXnPU4ItUMnSMGCSHCDp+vD+Z0O4
dcZql8ynHvSur9Zez121cuOOUlLceb/lm55TkgizRTo7TiMCAwEAAaNgMF4wDwYD
VR0TAQH/BAUwAwEB/zAfBgNVHSMEGDAWgBTBVzJnKRNEZOPQTXOQzeE+XMlMKzAd
BgNVHQ4EFgQUwVcyZykTRGTj0E1zkM3hPlzJTCswCwYDVR0PBAQDAgEGMA0GCSqG
SIb3DQEBCwUAA4IBAQB8zT8alwkm/MENoIBpcDbaKMjdYTMsRvVAolwxPUyh9zpv
PCgA7e/WnTqxxXm4tDqJpbIfmpXd1YXYi0ChfyYRBUUYkksofyunXgkqHpZkjs9a
OjkZuQYqQ6F7AcgVSQHfzMEm1I+7D1ruTELZgJaE5KJF1WwI7CEhnFfbJKxgl9Tv
01qtB+FRgrLtyCwJFXBqkl3e9ss6WL90VnbZdkh5/U2og8wQG7GhRdQbRB0ubYKw
612pMGIzfC9P5RSzz3LAZYriUiHBKtVZ2iHGFG+1szUtIG3fT60pgb+/g+FTwQgU
tXZJVX6zc9Y457U/tcp1LMqhyJHfSuLWI8s2oynL
-----END CERTIFICATE-----";

    /// <summary>
    /// Сертификат продукционной среды ЕСИА.
    /// </summary>
    public const string ProductionCertificate = @"-----BEGIN CERTIFICATE-----
MIIC+DCCAeCgAwIBAgIEaeoozTANBgkqhkiG9w0BAQsFADA+MQswCQYDVQQGEwJS
VTEPMA0GA1UECgwGUlRMYWJzMQ8wDQYDVQQLDAZSVExhYnMxDTALBgNVBAMMBEVT
SUEwHhcNMjYwNDIzMTQxMjI5WhcNMzAwNDMwMTQxMjI5WjA+MQswCQYDVQQGEwJS
VTEPMA0GA1UECgwGUlRMYWJzMQ8wDQYDVQQLDAZSVExhYnMxDTALBgNVBAMMBEVT
SUEwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCtY8U/c9WJS5lX0Dl4
97NuoYyxzE/m8HcemP57Ycv8i45pFKVAt0cRh9V3Ah8j+JqFlICwP7ydx7LSCzk0
fxO78kq23P8iM/jpuf5tPs+Uv3EEg5Tx6GUK3aoJ8OzV4WrqVu4TrvKgzDByhb4b
EPSYXTej3EriblNDvVHWVgaQ2esXGP1y9MKEIpZ5sP01wDAAH/MPWzeu+Hbmu3Qa
j3vfTHQGcSu/VuQcxk1cE+fJmqX5nvgKVu7Iwtfn5MK1rFDrwBrlyuBrjwaQLge2
C5sPQBofIL1hkD5LiX5N034Le2JT7f6HtIEIi3+E3mYjFSo2cqAaFc9BSnfYgYGq
0irFAgMBAAEwDQYJKoZIhvcNAQELBQADggEBAJOAlCjFuQeNsmaHfdDH8LqNr5Y3
dnJFkZvkKKL44J9m4vjWRz4NcOOzbSkxgfJREtezq72j4rdaGHnnEFxAZQfXljtj
kWBcwwGgFxJPX71cIzH8OqHVnjPRqi+vJRlOJQKEQKPWnikZF0Iml8FCaRGw7zmf
Kp3xlpnQMCA6C0hzughdf379JaCFYhGFRX6u3kySvn/GEJLGfpZfXtJk4m74rdlR
BgCqAP+rmaqC1dd5JPPvT929I5jG3OxG02ymfKhVBUEeMiiHX4e567f6QhM5c3nn
q1fwhijNm63YD8n2LZkQa6f7owTr/hCrhUVpVe0tu9ukt0lDRN2bfD9gINQ=
-----END CERTIFICATE-----";
}
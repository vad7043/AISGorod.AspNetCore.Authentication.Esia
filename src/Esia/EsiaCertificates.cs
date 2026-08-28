namespace AISGorod.AspNetCore.Authentication.Esia;

/// <summary>
/// Сертификаты тестовой и продуктивной сред ЕСИА, используемые для формирования электронных подписей ответов как поставщика.
/// Можно взять из архива http://esia.gosuslugi.ru/public/esia.zip.
/// Ссылка на архив взята из методических рекомендаций ЕСИА, п. 3.1.2 "Аутентификация с использованием OpenID Connect 1.0".
/// </summary>
/// <remarks>
/// ЕСИА меняет сертификаты без предварительного уведомления, поэтому для каждой среды хранится набор сертификатов
/// (прошлые, текущий и, если он уже известен, будущий). Все они передаются в параметры валидации токенов,
/// поэтому смена сертификата на стороне ЕСИА не приводит к отказу в обслуживании.
/// Имя константы содержит год выпуска сертификата.
/// </remarks>
internal static class EsiaCertificates
{
    /// <summary>
    /// Сертификат тестовой среды ЕСИА, выпущенный 06.08.2024 (действует до 06.08.2034).
    /// </summary>
    public const string TestCertificate2024 = @"-----BEGIN CERTIFICATE-----
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
    /// Сертификат продукционной среды ЕСИА, выпущенный 12.05.2024 (истёк 12.05.2025).
    /// </summary>
    public const string ProductionCertificate2024 = @"-----BEGIN CERTIFICATE-----
MIIC+DCCAeCgAwIBAgIEZkCOZTANBgkqhkiG9w0BAQsFADA+MQswCQYDVQQGEwJS
VTEPMA0GA1UECgwGUlRMYWJzMQ8wDQYDVQQLDAZSVExhYnMxDTALBgNVBAMMBEVT
SUEwHhcNMjQwNTEyMDkzOTQ5WhcNMjUwNTEyMDkzOTQ5WjA+MQswCQYDVQQGEwJS
VTEPMA0GA1UECgwGUlRMYWJzMQ8wDQYDVQQLDAZSVExhYnMxDTALBgNVBAMMBEVT
SUEwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCfZtVPWKNkkDlSyF5C
d8N6YHjj3MBDJ7JAvG/yYGOg9CqIOJ8y0oEZshBEIRlXuTnf6PARNAb0G6KJxjrR
NCw8vxfOhHxDiR/F/bez1Xyp7L9LIibw1kAMCScbAZobuOVekyvYsKC2JWur3KG+
NvS81FVVtLTWkwlIjZozioE7c4aQDAASGWmVCO2YC8TDExqUcgx4Dq+3d5RnfQrk
F+2QmTWPJVk9fvLX8foi+e/aQxR45Y6D6qSVHDkGt6cVt+FzAui1DyiDzRNNiECr
tqAGsIX4Y6uJxx3vhBxMVVSaGBQ2NEj8hmWpPubXhHez+OaXrN7Zy6wXFfgd8XB6
ej3NAgMBAAEwDQYJKoZIhvcNAQELBQADggEBAGJAgggo8qGX8ad+WUjTII/AYP/D
cSxUXSyGPnWXxr3t+7/EWphWbmFBEtI3Q9+mOHc9aIX4ExuaNzTTjZG7M5kXvt0B
54tI6bS9p7dlzAyrVrmGoBMHZWBez7EuexW4L7/gD1S/OV2Wn7XlofraFrAo+Sh3
6My5cwlIOWUzS4Rme7wmQ8oS7FyLdoxhTk81gUHBhxF2JHMToL58Zpx3CTPJRIyX
KDCLEUAg+/ZuPybz8Gq8xViNA+ThFYgbW8HXmCBlCPCrrw/VSHqhDPwnBKuPeO5Z
+mNJEAWLBRo34+8FfCaN+Fn0HNIdOGfwiH2yMFJitnT9ORIFEbDUY7zYV3E=
-----END CERTIFICATE-----";

    /// <summary>
    /// Сертификат продукционной среды ЕСИА, выпущенный 29.04.2025 (действует до 29.04.2026).
    /// </summary>
    public const string ProductionCertificate2025 = @"-----BEGIN CERTIFICATE-----
MIIC/DCCAeSgAwIBAgIIU+kXiIvlFgcwDQYJKoZIhvcNAQELBQAwPjELMAkGA1UE
BhMCUlUxDzANBgNVBAoTBlJUTGFiczEPMA0GA1UECxMGUlRMYWJzMQ0wCwYDVQQD
EwRFU0lBMB4XDTI1MDQyOTA4MTYwMFoXDTI2MDQyOTA4MTYwMFowPjELMAkGA1UE
BhMCUlUxDzANBgNVBAoTBlJUTGFiczEPMA0GA1UECxMGUlRMYWJzMQ0wCwYDVQQD
EwRFU0lBMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAqi0oaWj50Bl1
+87p0sPCFqBAV2jrOy0yLGmroYbMUGeJT93yK7/K60htYR477BYG34Wuz9rvr+0I
urL7mJ0sjYu+BdxH+WzTol08sCB2rFcGbO6hLhfz3l0cyrPCUgvDlBSCx7ZNDby7
OS/6Gm+J4KVKRIJZB57ZYRATpE9iZHj/L58rkxMyN/MFaUkjYaWFMrMfrz+NtRK/
3+sULYhqjkAAx8RUNtJO6het/e1VvwfMNxneVytpHBa0nB4XqiBbHCP7J/jmQWIz
vwwxjtamr0ODUzmh6ufjJFMNuZCn8s7UfIanrI5gKeez7qHkuhHdKHRRhi94TbJP
H9whoF4ZvQIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQAst71aPatAa7Fbp0FbdjNE
sT2MOIiiOwx57PNkId11Ryh1LRkZ98qog9CombS0bXbIAwTYjmmRJ6gDvLIBYssL
fFUA3OWNu+LUqidkNmdLYbwIu4UEJ9+4CsjWLzhHlHVCk1a4VUSPOFWzD2TCkRu+
x6VxibADYg8jzLlk+pWmPW9izZCs7etN0vTfj4eGMP18eNU1jI/oMfiMkUNPdI11
sl0dfK0oSP6vnowT+VyCxnie/rP12UZo4vApDo8Bvk4+KTEIKIYXeUjzivvLuyLS
pUPKADeUSRcek57OpIKm5bR1ezl/0BpjjuLFL4UyN1/tNLEritLyTgQ8E+LJwWiu
-----END CERTIFICATE-----";
}
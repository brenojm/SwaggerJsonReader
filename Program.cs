using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwaggerEndpoint.Models;
using System.Text;
using System.Text.Json.Serialization;

namespace SwaggerEndpoint
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //string swaggerUrl = "http://186.216.202.85:9091/swagger/v1/swagger.json";
            //using var httpClient = new HttpClient();
            //HttpResponseMessage response = await httpClient.GetAsync(swaggerUrl);
            //string jsonString = await response.Content.ReadAsStringAsync();
            string jsonString = @"{
  ""openapi"": ""3.0.1"",
  ""info"": {
    ""title"": ""SGP"",
    ""description"": ""\r\nLinks:\r\n  - Link para login -->  [Login Microsoft](https://login.microsoftonline.com/b545925d-9548-4587-889b-a1b79b107804/oauth2/authorize?client_id=bd45296c-a7b6-4b13-9723-203d3a195bd0&response_type=token&redirect_uri=https://brenojm.github.io/React-Token-SGP/&resource=bd45296c-a7b6-4b13-9723-203d3a195bd0&response_mode=fragment&state=12345&nonce=678910)\r\n         \r\n  - Link para o HangFire -->  [DashBoard](http://186.216.202.85:9091/hangfire/)"",
    ""version"": ""v1""
  },
  ""paths"": {
    ""/api/Administrator"": {
      ""get"": {
        ""tags"": [
          ""Administrator""
        ],
        ""summary"": ""Retorna uma lista com todos os administradores."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todos os administradores cadastrados.""
          }
        }
      },
      ""post"": {
        ""tags"": [
          ""Administrator""
        ],
        ""summary"": ""Registra um administrador"",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    POST /Administrator\r\n    {\r\n       \""username\"": \""administrador\"",\r\n       \""password\"": \""1234\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOPost""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOPost""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOPost""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o token para utilização no front.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/Administrator/{id}"": {
      ""get"": {
        ""tags"": [
          ""Administrator""
        ],
        ""summary"": ""Realiza busca por ID para localizar um administrador específico."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o administrador específico e suas informações.""
          },
          ""404"": {
            ""description"": ""administrador não encontrado.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""Administrator""
        ],
        ""summary"": ""Atualiza o username de um administrador pelo ID."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    PUT /Administrator/{id}\r\n    {\r\n       \""username\"": \""admin\""\r\n    }"",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOPut""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOPut""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOPut""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o administrador editado""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          },
          ""404"": {
            ""description"": ""Administrador não encontrado.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""Administrator""
        ],
        ""summary"": ""Exclui um administrador específico."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que o administrador foi excluído com sucesso.""
          },
          ""404"": {
            ""description"": ""administrador não encontrado.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/Administrator/Login"": {
      ""post"": {
        ""tags"": [
          ""Administrator""
        ],
        ""summary"": ""Login administrador"",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    POST /Administrator/Login\r\n    {\r\n       \""username\"": \""administrador\"",\r\n       \""password\"": \""1234\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOLogin""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOLogin""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOLogin""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o token de acesso.""
          },
          ""401"": {
            ""description"": ""Esse erro ocorre quando o token de autenticação não é fornecido""
          },
          ""403"": {
            ""description"": ""Esse erro ocorre quando o usuário não é autenticado""
          }
        }
      }
    },
    ""/api/ChangePassword/{id}"": {
      ""put"": {
        ""tags"": [
          ""Administrator""
        ],
        ""summary"": ""Atualiza a senha de um administrador pelo ID."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    PUT /Administrator/ChangePassword/{id}\r\n    {\r\n       \""password\"": \""1234\"",\r\n       \""confirmPassword\"": \""1234\""\r\n    }"",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOUpdatePassword""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOUpdatePassword""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/AdministratorDTOUpdatePassword""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o administrador editado""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          },
          ""404"": {
            ""description"": ""Administrador não encontrado.""
          }
        }
      }
    },
    ""/api/Duties"": {
      ""get"": {
        ""tags"": [
          ""Duties""
        ],
        ""summary"": ""Retorna uma lista de usuários com permissão de Gestor."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista de usuários com permissão de Gestor.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""Duties""
        ],
        ""summary"": ""Atualiza as permissões de um usuário."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    PUT /Duties\r\n    {\r\n       \""id\"": 1,     \r\n       \""email\"": \""usuario@t2mlab.com\"",\r\n       \""role\"": \""Gestor\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/DutiesDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/DutiesDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/DutiesDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o usuário com permissão recém atualizada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          },
          ""404"": {
            ""description"": ""Usuário não encontrado.""
          }
        }
      }
    },
    ""/api/Duties/{id}"": {
      ""get"": {
        ""tags"": [
          ""Duties""
        ],
        ""summary"": ""Realiza busca por ID para localizar um Gertor específico."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o Gestor específico e suas informações.""
          },
          ""404"": {
            ""description"": ""Gestor não encontrado.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""Duties""
        ],
        ""summary"": ""Cancela uma permissão de usuário específica."",
        ""description"": ""Ao cancelar uma permissão, o usuário retorna ao status de Colaborador."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que a permissão de usuário foi cancelada com sucesso.""
          },
          ""404"": {
            ""description"": ""Usuário não encontrado.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/Duties/register"": {
      ""post"": {
        ""tags"": [
          ""Duties""
        ],
        ""summary"": ""Cria uma nova permissão para o usuário."",
        ""description"": ""É possível atribuir permissão de Gestor para um usuário.\r\nExemplo com campos obrigatórios:\r\n            \r\n    POST /Duties/register\r\n    {\r\n       \""email\"": \""usuario@t2mlab.com\"",    \r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/DutiesResponseDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/DutiesResponseDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/DutiesResponseDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          },
          ""201"": {
            ""description"": ""Retorna o usuário com permissão recém criada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/Limit"": {
      ""get"": {
        ""tags"": [
          ""Limit""
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""Limit""
        ],
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/LimitDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/LimitDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/LimitDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/date"": {
      ""get"": {
        ""tags"": [
          ""Limit""
        ],
        ""parameters"": [
          {
            ""name"": ""date"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Limit/register"": {
      ""post"": {
        ""tags"": [
          ""Limit""
        ],
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/LimitDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/LimitDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/LimitDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Limit/{id}"": {
      ""delete"": {
        ""tags"": [
          ""Limit""
        ],
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Logger/reserva-sala-de-reuniao"": {
      ""get"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Retorna os logs de reserva de sala de reunião."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna os logs de reserva de sala de reuniao.""
          }
        }
      }
    },
    ""/api/Logger/alteracao-de-reservas"": {
      ""get"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Retorna os logs de alteração de reservas."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna os logs de alteração de reservas.""
          }
        }
      }
    },
    ""/api/Logger/cancelamento-de-ativos"": {
      ""get"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Retorna os logs de cancelamento de ativos."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna os logs de cancelamento de ativos.""
          }
        }
      }
    },
    ""/api/Logger/cancelamento-de-reservas"": {
      ""get"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Retorna os logs de cancelamento de reservas."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna os logs de cancelamento de reservas.""
          }
        }
      }
    },
    ""/api/Logger/logs-excluidos"": {
      ""get"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Retorna os logs excluidos."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna os logs excluidos.""
          }
        }
      }
    },
    ""/api/Logger/reserva-mesa"": {
      ""get"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Retorna os logs de reserva de mesa."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna os logs de reserva de mesa.""
          }
        }
      }
    },
    ""/api/Logger/reserva-posicao"": {
      ""get"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Retorna os logs de reserva de posição."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna os logs de reserva de posição.""
          }
        }
      }
    },
    ""/api/Logger/{fileName}"": {
      ""delete"": {
        ""tags"": [
          ""Logger""
        ],
        ""summary"": ""Log deletado."",
        ""parameters"": [
          {
            ""name"": ""fileName"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o logs deletado.""
          }
        }
      }
    },
    ""/api/MeetingRoom"": {
      ""get"": {
        ""tags"": [
          ""MeetingRoom""
        ],
        ""summary"": ""Retorna uma lista com todas as salas de reunião cadastradas."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todos os horarios disponiveis.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""MeetingRoom""
        ],
        ""summary"": ""Atualiza uma sala de reunião."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    PUT /MeetingRoom\r\n    {\r\n       \""id\"": 1,\r\n       \""name\"": 1,\r\n       \""capacity\"": 5,\r\n       \""office\"": \""Escritório 1\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/MeetingRoomDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/MeetingRoomDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/MeetingRoomDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna a sala de reunião recém atualizada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          },
          ""404"": {
            ""description"": ""Sala de reunião não encontrada.""
          }
        }
      }
    },
    ""/api/hours"": {
      ""post"": {
        ""tags"": [
          ""MeetingRoom""
        ],
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/VerifyHoursDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/VerifyHoursDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/VerifyHoursDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/MeetingRoom/{id}"": {
      ""get"": {
        ""tags"": [
          ""MeetingRoom""
        ],
        ""summary"": ""Realiza busca por ID para localizar uma sala de reunião específica."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma sala de reunião específica.""
          },
          ""404"": {
            ""description"": ""Sala de reunião não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""MeetingRoom""
        ],
        ""summary"": ""Exclui uma sala de reunião específica."",
        ""description"": ""Não é possível excluir uma sala de reunião que possua reservas ativas. Para excluir uma sala de reunião, é necessário excluir todas as suas reservas primeiro."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que a sala de reunião foi excluída com sucesso.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Não é possível excluir uma sala de reunião que possua reservas ativas.""
          },
          ""404"": {
            ""description"": ""Sala de reunião não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/MeetingRoom/register"": {
      ""post"": {
        ""tags"": [
          ""MeetingRoom""
        ],
        ""summary"": ""Cria uma nova sala de reunião."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    POST /MeetingRoom/register\r\n    {\r\n       \""name\"": 1,\r\n       \""capacity\"": 5,\r\n       \""office\"": \""Escritório 1\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponseMeetingRoomDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponseMeetingRoomDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponseMeetingRoomDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          },
          ""201"": {
            ""description"": ""Retorna a sala de reunião recém criada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/Notification"": {
      ""get"": {
        ""tags"": [
          ""Notification""
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Notification/public"": {
      ""get"": {
        ""tags"": [
          ""Notification""
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Notification/email"": {
      ""get"": {
        ""tags"": [
          ""Notification""
        ],
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Notification/email/notview"": {
      ""get"": {
        ""tags"": [
          ""Notification""
        ],
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Notification/{id}"": {
      ""get"": {
        ""tags"": [
          ""Notification""
        ],
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""Notification""
        ],
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""Notification""
        ],
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Notification/create"": {
      ""post"": {
        ""tags"": [
          ""Notification""
        ],
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/NotificationDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/NotificationDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/NotificationDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Position"": {
      ""get"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Retorna uma lista com todas as posições cadastradas."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as posições cadastradas.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""O método para atualizar mesa está temporariamente desativado."",
        ""description"": ""O método para atualizar mesa está temporariamente desativado. Em caso de alterações, será necessário excluir a mesa e adicioná-la novamente.\r\n\r\nQuando uma mesa é excluída, as posições registradas nela também serão excluídas caso não tenham reservas ativas. Será necessário adicionar primeiro a mesa e depois suas posições."",
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Position/date/morning"": {
      ""get"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Retorna uma lista com todas as posições cadastradas."",
        ""parameters"": [
          {
            ""name"": ""date"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as posições disponiveis pro turno da manha.""
          }
        }
      }
    },
    ""/api/Position/date/afternoon"": {
      ""get"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Retorna uma lista com todas as posições cadastradas."",
        ""parameters"": [
          {
            ""name"": ""date"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as posições disponiveis pro turno da tarde.""
          }
        }
      }
    },
    ""/api/Position/date/fullshift"": {
      ""get"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Retorna uma lista com todas as posições cadastradas."",
        ""parameters"": [
          {
            ""name"": ""date"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as posições todas as posições disponiveis para turno integral.""
          }
        }
      }
    },
    ""/api/Position/verify"": {
      ""get"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Retorna uma lista com todas as posições ocupadas de uma mesa, naquele dia."",
        ""parameters"": [
          {
            ""name"": ""date"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          },
          {
            ""name"": ""table"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as posições todas as posições disponiveis para turno integral.""
          }
        }
      }
    },
    ""/api/Position/{id}"": {
      ""get"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Realiza busca por ID para localizar uma posição específica."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma posição específica.""
          },
          ""404"": {
            ""description"": ""Posição não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Exclui uma posição específica."",
        ""description"": ""Não é possível excluir uma posição que possua reservas ativas. Para excluir uma posição, é necessário excluir todas as suas reservas primeiro."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que a posição foi excluída com sucesso.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Não é possível excluir uma posição que possua reservas ativas.""
          },
          ""404"": {
            ""description"": ""Posição não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/Position/register"": {
      ""post"": {
        ""tags"": [
          ""Position""
        ],
        ""summary"": ""Cria uma nova posição."",
        ""description"": ""Para criar uma nova posição é necessário informar o nome de uma mesa que já esteja cadastrada no sistema.\r\n\r\nExemplo com campos obrigatórios:\r\n            \r\n    POST /Position/register\r\n    {\r\n       \""name\"": \""A1\"",\r\n       \""tableName\"": \""A\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponsePositionDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponsePositionDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponsePositionDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          },
          ""201"": {
            ""description"": ""Retorna a posição recém criada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/PositionReservation"": {
      ""get"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Retorna uma lista com todas as reservas em posições."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as reservas em posições.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Atualiza uma reserva de posição."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    PUT /PositionReservation\r\n    {\r\n       \""id\"": 14,\r\n       \""userEmail\"": \""colaborador@t2mlab.com\"",\r\n       \""reservationDate\"": \""2023-05-05T10:00:00.485Z\"",\r\n       \""positionName\"": \""A2\"",\r\n       \""workshift\"": \""manhã\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/PositionReservationDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/PositionReservationDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/PositionReservationDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna a reserva de posição recém atualizada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          },
          ""404"": {
            ""description"": ""Reserva de posição não encontrada.""
          }
        }
      }
    },
    ""/api/PositionReservation/date/name"": {
      ""get"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Retorna uma lista com todas as reservas em posições."",
        ""parameters"": [
          {
            ""name"": ""date"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          },
          {
            ""name"": ""name"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as reservas em posições.""
          }
        }
      }
    },
    ""/api/PositionReservation/{id}"": {
      ""get"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Realiza busca por ID para localizar uma reserva de posição específica."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma reserva de posição específica.""
          },
          ""404"": {
            ""description"": ""Reserva de posição não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Exclui uma reserva de posição específica."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que a posição foi excluída com sucesso.""
          },
          ""404"": {
            ""description"": ""Reserva de posição não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/PositionReservation/email"": {
      ""get"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Realiza busca por E-mail para localizar uma reserva de posição específica."",
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma reserva de posição específica.""
          },
          ""404"": {
            ""description"": ""Reserva de posição não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/PositionReservation/date"": {
      ""get"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Realiza busca por Data para localizar uma reserva de posição específica."",
        ""parameters"": [
          {
            ""name"": ""data"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma reserva de posição específica.""
          },
          ""404"": {
            ""description"": ""Reserva de posição não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/PositionReservation/register"": {
      ""post"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Cria uma nova reserva de posição."",
        ""description"": ""A reserva de posição possui algumas regras:\r\n- Não é possível realizar reservas retroativas;\r\n- Não é possível realizar reservas para um período inferior a 1h;\r\n- As reservas podem ser realizadas por turnos ou período integral (Turno da manhã: 8h às 12h | Turno da tarde: 13h às 18h | Turno integral: 8h às 18h);\r\n- O colaborador não pode ter mais do que duas reservas para o mesmo dia;\r\n- As reservas só podem ser realizadas durante o horário de funcionamento (8h às 19h);\r\n- Não é possível realizar uma reserva caso a posição já esteja reservada para a data/horário desejados.\r\n\r\nExemplo com campos obrigatórios:\r\n            \r\n    POST /PositionReservation/register\r\n    {\r\n       \""userEmail\"": \""colaborador@t2mlab.com\"",\r\n       \""reservationDate\"": \""2023-05-05T09:00:00.485Z\"",\r\n       \""positionName\"": \""A2\"",\r\n       \""workshift\"": \""manhã\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/PositionReservationDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/PositionReservationDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/PositionReservationDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          },
          ""201"": {
            ""description"": ""Retorna a reserva da posição recém criada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/PositionReservation/register/collaborator"": {
      ""post"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ReservationCollaboratorDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ReservationCollaboratorDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ReservationCollaboratorDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/PositionReservation/{email}/{id}"": {
      ""delete"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""string""
            }
          },
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/PositionReservation/limit"": {
      ""post"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Altera o limite do número de reservas."",
        ""description"": ""Para alterar o limite do número de reservas, deve ser informado o limite, uma data de início e uma data de fim para esse novo limite."",
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          },
          {
            ""name"": ""value"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          },
          {
            ""name"": ""startDate"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          },
          {
            ""name"": ""endDate"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o novo limite e o período estabelecido para esse limite.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/PositionReservation/tableReservation"": {
      ""post"": {
        ""tags"": [
          ""PositionReservation""
        ],
        ""summary"": ""Cria uma nova reserva de assentos multiplos."",
        ""description"": "" Para realizar uma reserva múltipla é necessário informar qual colaborador ocupará cada posição dessa mesa.\r\n \r\n Uma reserva de mesa inteira não pode ter posições vazias.\r\n \r\n Exemplo com campos obrigatórios:\r\n\r\n     POST /PositionReservation/tableReservation\r\n     {\r\n            \""tableName\"": \""string\"",\r\n           \""gestorEmail\"": \""string\"",\r\n           \""information\"": [\r\n                         {\r\n                          \""email\"": \""string\"",\r\n                        \""position\"": \""string\""\r\n                      }\r\n                       ],\r\n  \""dateReservation\"": \""2023-07-17T21:00:29.063Z\"",\r\n  \""workshift\"": \""string\""\r\n}"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RequestMultiple""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RequestMultiple""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RequestMultiple""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna a reserva de mesa recém criada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/RoomReservation"": {
      ""get"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""Retorna uma lista com todas as reservas em salas de reunião."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as reservas em salas de reunião.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""O método para atualizar reserva de sala de reunião está temporariamente desativado."",
        ""description"": ""O método para atualizar uma reserva de Sala de Reunião está temporariamente desativado.\r\n\r\nEm caso de alterações, será necessário excluir a reserva e realizar uma nova reserva."",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RoomReservationDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RoomReservationDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RoomReservationDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/RoomReservation/email/participante"": {
      ""get"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""Retorna uma lista com todas as reservas em salas de reunião baseadas no e-mail passado."",
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as reservas em salas de reunião.""
          }
        }
      }
    },
    ""/api/RoomReservation/email"": {
      ""get"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""Retorna uma lista com todas as reservas em salas de reunião baseadas no e-mail passado."",
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as reservas em salas de reunião.""
          }
        }
      }
    },
    ""/api/RoomReservation/{id}"": {
      ""get"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""Realiza busca por ID para localizar uma reserva de sala de reunião específica."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma reserva de sala de reunião específica.""
          },
          ""404"": {
            ""description"": ""Reserva de sala de reunião não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""Exclui uma reserva de sala de reunião específica."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que a sala de reunião foi excluída com sucesso.""
          },
          ""404"": {
            ""description"": ""Reserva de sala de reunião não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/RoomReservation/date"": {
      ""get"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""Realiza busca por Data para localizar uma reserva de sala de reunião específica."",
        ""parameters"": [
          {
            ""name"": ""data"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            }
          },
          {
            ""name"": ""name"",
            ""in"": ""query"",
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma reserva de sala de reunião específica.""
          },
          ""404"": {
            ""description"": ""Reserva de sala de reunião não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/RoomReservation/register"": {
      ""post"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""summary"": ""Cria uma nova reserva de sala de reunião."",
        ""description"": ""A reserva da sala de reunião possui algumas regras:\r\n- Não é possível realizar reservas retroativas;\r\n- Não é possível realizar reservas para um período inferior a 1h;\r\n- As reservas podem ser realizadas por hora/horas, turnos ou período integral (Turno da manhã: 8h às 12h | Turno da tarde: 13h às 18h | Turno integral: 8h às 18h);\r\n- As reservas só podem ser realizadas durante o horário de funcionamento (8h às 19h);\r\n- Não é possível realizar uma reserva caso a sala já esteja reservada para a data/horário desejados.\r\n\r\nExemplo com campos obrigatórios:\r\n            \r\n    POST /RoomReservation/register\r\n    {\r\n       \""userEmail\"": \""colaborador@t2mlab.com\"",\r\n       \""meetingRoomName\"": 1,\r\n       \""startDate\"": \""2023-05-04T16:00:00.181Z\"",\r\n       \""endDate\"": \""2023-05-04T17:00:00.181Z\"",\r\n       \""reservationDate\"": \""2023-05-03T16:56:11.181Z\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RoomReservationDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RoomReservationDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/RoomReservationDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          },
          ""201"": {
            ""description"": ""Retorna a reserva da sala de reunião recém criada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/RoomReservation/{email}/{id}"": {
      ""delete"": {
        ""tags"": [
          ""RoomReservation""
        ],
        ""parameters"": [
          {
            ""name"": ""email"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""string""
            }
          },
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Table"": {
      ""get"": {
        ""tags"": [
          ""Table""
        ],
        ""summary"": ""Retorna uma lista com todas as mesas cadastradas."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todas as mesas cadastradas.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""Table""
        ],
        ""summary"": ""O método para atualizar mesa está temporariamente desativado."",
        ""description"": ""O método para atualizar mesa está temporariamente desativado. Em caso de alterações, será necessário excluir a mesa e adicioná-la novamente.\r\n\r\nQuando uma mesa é excluída, as posições registradas nela também serão excluídas caso não tenham reservas ativas. Será necessário adicionar primeiro a mesa e depois suas posições."",
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/Table/{id}"": {
      ""get"": {
        ""tags"": [
          ""Table""
        ],
        ""summary"": ""Realiza busca por ID para localizar uma mesa específica."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mesa específica.""
          },
          ""404"": {
            ""description"": ""Mesa não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""Table""
        ],
        ""summary"": ""Exclui uma mesa específica."",
        ""description"": ""Não é possível excluir uma mesa que possua reservas ativas. Para excluir uma mesa, é necessário excluir todas as suas reservas primeiro."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que a mesa foi excluída com sucesso.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Não é possível excluir uma mesa que possua reservas ativas.""
          },
          ""404"": {
            ""description"": ""Mesa não encontrada.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/Table/register"": {
      ""post"": {
        ""tags"": [
          ""Table""
        ],
        ""summary"": ""Cria uma nova mesa."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    POST /Table/register\r\n    {\r\n       \""name\"": \""A\"",\r\n       \""capacity\"": 10,\r\n       \""office\"": \""Escritório 1\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponseTableDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponseTableDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/ResponseTableDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          },
          ""201"": {
            ""description"": ""Retorna a mesa recém criada.""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          }
        }
      }
    },
    ""/api/User"": {
      ""get"": {
        ""tags"": [
          ""User""
        ],
        ""summary"": ""Retorna uma lista com todos os usuários cadastrados."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todos os usuários cadastrados.""
          }
        }
      },
      ""put"": {
        ""tags"": [
          ""User""
        ],
        ""summary"": ""Atualiza as informações de um usuário."",
        ""description"": ""Exemplo com campos obrigatórios:\r\n            \r\n    PUT /User\r\n    {\r\n       \""id\"": 1,\r\n       \""name\"": \""Colaborador\"",\r\n       \""email\"": \""colaborador@t2mlab.com\""\r\n    }"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/UserDTO""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/UserDTO""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""$ref"": ""#/components/schemas/UserDTO""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o usuário editado""
          },
          ""400"": {
            ""description"": ""Solicitação inválida. Esse erro ocorre quando algum campo obrigatório não foi devidamente preenchido.""
          },
          ""404"": {
            ""description"": ""Usuário não encontrado.""
          }
        }
      }
    },
    ""/api/User/collaborator"": {
      ""get"": {
        ""tags"": [
          ""User""
        ],
        ""summary"": ""Retorna uma lista com todos os usuários cadastrados."",
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma lista com todos os usuários cadastrados.""
          }
        }
      }
    },
    ""/api/User/{id}"": {
      ""get"": {
        ""tags"": [
          ""User""
        ],
        ""summary"": ""Realiza busca por ID para localizar um usuário específico."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna o usuário específico e suas informações.""
          },
          ""404"": {
            ""description"": ""Usuário não encontrado.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      },
      ""delete"": {
        ""tags"": [
          ""User""
        ],
        ""summary"": ""Exclui um usuário específico."",
        ""description"": ""Não é possível excluir um usuário que tenha reservas ativas. Nesse caso, é necessário excluir primeiro todas as reservas vinculadas a esse usuário."",
        ""parameters"": [
          {
            ""name"": ""id"",
            ""in"": ""path"",
            ""required"": true,
            ""schema"": {
              ""type"": ""integer"",
              ""format"": ""int32""
            }
          }
        ],
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que o usuário foi excluído com sucesso.""
          },
          ""404"": {
            ""description"": ""Usuário não encontrado.""
          },
          ""406"": {
            ""description"": ""Caractere inaceitável.""
          }
        }
      }
    },
    ""/api/User/login"": {
      ""post"": {
        ""tags"": [
          ""User""
        ],
        ""summary"": ""Loga na aplicação, utilizando o token fornecido pela microsoft"",
        ""responses"": {
          ""200"": {
            ""description"": ""Success""
          }
        }
      }
    },
    ""/api/User/deleteLogs"": {
      ""delete"": {
        ""tags"": [
          ""User""
        ],
        ""summary"": ""Exclui um log específico."",
        ""description"": ""Esse método permite excluir um arquivo de log específico.\r\n- LogsAlteracaoReservas\r\n- LogsCancelamentoAtivos\r\n- LogsCancelamentoReservas\r\n- LogsCancelamentoUsuarios\r\n- LogsReservaMesa\r\n- LogsReservaSalaReuniao\r\n- LogsReservaPosicao"",
        ""requestBody"": {
          ""content"": {
            ""application/json"": {
              ""schema"": {
                ""type"": ""string""
              }
            },
            ""text/json"": {
              ""schema"": {
                ""type"": ""string""
              }
            },
            ""application/*+json"": {
              ""schema"": {
                ""type"": ""string""
              }
            }
          }
        },
        ""responses"": {
          ""200"": {
            ""description"": ""Retorna uma mensagem informando que o log foi excluído com sucesso.""
          },
          ""400"": {
            ""description"": ""Nome do arquivo inválido.""
          }
        }
      }
    }
  },
  ""components"": {
    ""schemas"": {
      ""AdministratorDTOLogin"": {
        ""type"": ""object"",
        ""properties"": {
          ""username"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""password"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""AdministratorDTOPost"": {
        ""type"": ""object"",
        ""properties"": {
          ""username"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""password"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""AdministratorDTOPut"": {
        ""type"": ""object"",
        ""properties"": {
          ""username"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""AdministratorDTOUpdatePassword"": {
        ""type"": ""object"",
        ""properties"": {
          ""password"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""confirmPassword"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""DutiesDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32"",
            ""nullable"": true
          },
          ""email"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""role"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""DutiesResponseDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""email"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""LimitDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""limitReservation"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""start"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""end"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          }
        },
        ""additionalProperties"": false
      },
      ""MeetingRoomDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32"",
            ""nullable"": true
          },
          ""name"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""capacity"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""office"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""roomReservations"": {
            ""type"": ""array"",
            ""items"": {
              ""$ref"": ""#/components/schemas/RoomReservation""
            },
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""MultipleClass"": {
        ""type"": ""object"",
        ""properties"": {
          ""email"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""position"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""NotificationDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""title"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""message"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""date"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""check"": {
            ""type"": ""boolean""
          },
          ""userEmail"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""PositionReservation"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""reservationDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""workshift"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""PositionReservationDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32"",
            ""nullable"": true
          },
          ""userEmail"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""reservationDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""positionName"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""workshift"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""RequestMultiple"": {
        ""type"": ""object"",
        ""properties"": {
          ""tableName"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""gestorEmail"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""information"": {
            ""type"": ""array"",
            ""items"": {
              ""$ref"": ""#/components/schemas/MultipleClass""
            },
            ""nullable"": true
          },
          ""dateReservation"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""workshift"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""ReservationCollaboratorDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""gestorEmail"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""collaboratorEmail"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""reservationDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""positionName"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""workshift"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""ResponseMeetingRoomDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""name"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""capacity"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""office"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""ResponsePositionDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""name"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""tableName"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""ResponseTableDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""name"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""capacity"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""office"": {
            ""type"": ""string"",
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""RoomReservation"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""startDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""endDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""reservationDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""reservationTurn"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""participants"": {
            ""type"": ""array"",
            ""items"": {
              ""type"": ""string""
            },
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""RoomReservationDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32"",
            ""nullable"": true
          },
          ""userEmail"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""meetingRoomName"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""startDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""endDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""reservationDate"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""reservationTurn"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""participants"": {
            ""type"": ""array"",
            ""items"": {
              ""type"": ""string""
            },
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""UserDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""id"": {
            ""type"": ""integer"",
            ""format"": ""int32"",
            ""nullable"": true
          },
          ""name"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""email"": {
            ""type"": ""string"",
            ""nullable"": true
          },
          ""positionReservations"": {
            ""type"": ""array"",
            ""items"": {
              ""$ref"": ""#/components/schemas/PositionReservation""
            },
            ""nullable"": true
          },
          ""roomReservations"": {
            ""type"": ""array"",
            ""items"": {
              ""$ref"": ""#/components/schemas/RoomReservation""
            },
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      },
      ""VerifyHoursDTO"": {
        ""type"": ""object"",
        ""properties"": {
          ""tableName"": {
            ""type"": ""integer"",
            ""format"": ""int32""
          },
          ""date"": {
            ""type"": ""string"",
            ""format"": ""date-time""
          },
          ""hours"": {
            ""type"": ""array"",
            ""items"": {
              ""type"": ""string"",
              ""format"": ""date-time""
            },
            ""nullable"": true
          }
        },
        ""additionalProperties"": false
      }
    },
    ""securitySchemes"": {
      ""Bearer"": {
        ""type"": ""apiKey"",
        ""description"": ""Authentication with JWT .\r\n                                    Ex: Bearer {token}"",
        ""name"": ""Authorization"",
        ""in"": ""header""
      }
    }
  },
  ""security"": [
    {
      ""Bearer"": [
        
      ]
    }
  ]
}";

            var settings = new JsonSerializerSettings();
            settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;

            Console.WriteLine(jsonString);

            SwaggerDocument SwaggerDocument = JsonConvert.DeserializeObject<SwaggerDocument>(jsonString, settings);

            Console.WriteLine(SwaggerDocument);

        }


    }
}
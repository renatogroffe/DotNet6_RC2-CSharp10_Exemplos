namespace APIConversoes.Controllers;

[ApiController]
[Route("[controller]")]
public class ConversorDistanciasController : ControllerBase
{
    private readonly ILogger<ConversorDistanciasController> _logger;

    public ConversorDistanciasController(ILogger<ConversorDistanciasController> logger)
    {
        _logger = logger;
    }

    [HttpGet("Milhas/{distancia}")]
    [ProducesResponseType(typeof(Distancia), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(FalhaCalculo), (int)HttpStatusCode.BadRequest)]
    public ActionResult<Distancia> GetConversaoMilhas(double distancia)
    {
        _logger.LogInformation(
            $"Recebida distancia para conversao: {distancia}");

        if (distancia <= 0)
        {
            var mensagemErro =
                $"Distancia em Milhas invalida: {distancia}";
            _logger.LogError(mensagemErro);
            return new BadRequestObjectResult(
                new FalhaCalculo()
                {
                    Mensagem = mensagemErro
                });
        }

        var resultado = new Distancia(distancia);
        _logger.LogInformation(
            $"{resultado.Milhas} milhas = " +
            $"{resultado.Km} Km");
        return resultado;
    }
}
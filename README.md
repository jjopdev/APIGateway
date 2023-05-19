# APIGateway

Este es el repositorio principal del proyecto APIGateway, el cual funciona como una API Gateway para una tienda online.

## Descripción

APIGateway es una solución basada en microservicios que proporciona un punto de entrada centralizado para acceder a los diversos servicios de una tienda en línea. Está desarrollado en .NET 7 y sigue una arquitectura limpia y modular.

## Estructura del repositorio

El repositorio sigue la siguiente estructura de carpetas:

- **APIGateway.Application**: Contiene la capa de aplicación que implementa la lógica del negocio.
- **APIGateway.Domain**: Contiene la capa de dominio que define los modelos y las reglas de negocio.
- **APIGateway.Infrastructure**: Contiene la capa de infraestructura que proporciona implementaciones concretas para la persistencia de datos y otros servicios externos.
  - **APIGateway.Infrastructure.Database**: Contiene la implementación de la capa de acceso a datos utilizando el repositorio APIGateway-Database (enlace al repositorio: [APIGateway-Database](https://github.com/juanou/APIGateway-Database)).
  - **APIGateway.Infrastructure.ExternalServices**: Contiene la implementación de los servicios externos utilizados por la API Gateway.
- **APIGateway.Presentation**: Contiene la capa de presentación de tipo API que expone los endpoints de la API Gateway.
- **APIGateway.Tests**: Contiene las pruebas unitarias y de integración para el proyecto.
- **APIGateway.Shared**: Contiene componentes compartidos utilizados por otras capas del proyecto.

## Configuración

Para ejecutar el proyecto, asegúrate de tener instalado .NET 7 en tu máquina.

## Instalación

Sigue los siguientes pasos para ejecutar el proyecto en tu máquina local:

1. Clona este repositorio en tu máquina local:

   ```bash
   git clone https://github.com/tu-usuario/APIGateway.git

2. Navega al directorio del proyecto:
   
    ```bash
    cd APIGateway

3. Restaura las dependencias del proyecto:
    
    ```bash
    dotnet restore

4. Compila el proyecto
    
    ```bash
    dotnet build

5. Ejecuta el proyecto
    
    ```bash
    dotnet run --project APIGateway.Presentation


## Contribución

Si deseas contribuir a este proyecto, siéntete libre de hacer un fork y enviar tus pull requests. También puedes abrir issues si encuentras algún problema o tienes alguna sugerencia.

## Licencia

Este proyecto está bajo la licencia MIT.




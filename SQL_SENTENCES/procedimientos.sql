/* Empleados */

CREATE PROC mostrar_empleados
AS
SELECT * FROM empleados ORDER BY id_usuario desc;
GO

CREATE PROC insertar_empleado
@usuario VARCHAR(20),
@contrasena VARCHAR(20)
AS
INSERT INTO empleados VALUES(@usuario,@contrasena);
GO

CREATE PROC actualizar_empleado
@cod_empleado int,
@usuario VARCHAR(20),
@contrasena VARCHAR(20)
AS
UPDATE empleados SET usuario=@usuario,contrasena=@contrasena WHERE cod_empleado=@cod_empleado;
GO

create proc eliminar_empleado 
@cod_empleado int
as
DELETE FROM empleados WHERE cod_empleado=@cod_empleado;
GO

CREATE PROC BuscarEmpleadoPorNombre
@nombre varchar(50)
AS
SELECT * FROM empleados WHERE nombre=@nombre;
GO
/* ------------------------------------------------------- */
/* Clientes */

CREATE PROC mostrar_clientes
AS
SELECT * FROM clientes ORDER BY id_cliente desc;
GO

CREATE PROC insertar_cliente
@id_cliente VARCHAR(8),
@nombre varchar(50),
@apellido varchar(50),
@direccion varchar(50),
@zona varchar(50),
@celular varchar(12),
@email varchar(50),
@estado_cliente varchar(10)
AS
if exists (select id_cliente from Clientes WHERE id_cliente=@id_cliente)
RAISERROR ('Ya existe un usuario con ese Usuario, Por favor ingrese de nuevo',16,1)
INSERT INTO clientes VALUES(@id_cliente,@nombre,@apellido,@direccion,@zona,@celular,@email,@estado_cliente);
GO

CREATE PROC actualizar_cliente
@id_cliente VARCHAR(8),
@nombre varchar(50),
@apellido varchar(50),
@direccion varchar(200),
@zona varchar(50),
@celular varchar(12),
@email varchar(50),
@estado_cliente varchar(10)
AS
UPDATE clientes SET nombre=@nombre,apellido=@apellido,direccion=@direccion,
zona=@zona,celular=@celular,email=@email,estado_cliente=@estado_cliente WHERE id_cliente=@id_cliente;
GO

CREATE PROC eliminar_cliente
@id_cliente VARCHAR(8)
AS
-- Delete rows from table 'clientes'
DELETE FROM clientes
WHERE id_cliente=@id_cliente	/* add search conditions here */
GO

CREATE PROC BuscarClientePorDni
@id_cliente VARCHAR(8)
AS
SELECT * FROM clientes WHERE id_cliente=@id_cliente;
GO
/* --------------------------------------------------- */
/* Planes */
CREATE PROC mostrar_planes
AS
SELECT * FROM planes;
go

CREATE PROC insertar_plan
@id_plan VARCHAR(20),
@descripcion VARCHAR(200)
AS
if exists (select id_plan from planes WHERE id_plan=@id_plan)
RAISERROR ('Ya existe este plan, Por favor otra nombre',16,1)
INSERT INTO planes VALUES(@id_plan,@descripcion);
GO

CREATE PROC actualizar_plan
@id_plan VARCHAR(20),
@descripcion VARCHAR(200)
AS 
UPDATE planes SET descripcion=@descripcion WHERE id_plan=@id_plan;
GO

CREATE PROC eliminar_plan
@id_plan VARCHAR(20)
as
DELETE FROM planes WHERE id_plan=@id_plan
GO

CREATE PROC BuscarPlanPorID
@id_plan VARCHAR(20)
AS
SELECT * FROM planes WHERE id_plan=@id_plan;
GO
/* --------------------------------------------- */
/* Servicios */
CREATE PROC mostrar_servicios
AS
SELECT * FROM servicios;
go

CREATE PROC insertar_servicio
@tipo_servicio varchar(20),
@precio_servicio SMALLMONEY,
@id_plan varchar(20)
AS
INSERT INTO servicios VALUES(@tipo_servicio,@precio_servicio,@id_plan);
GO

CREATE PROC actualizar_servicio
@id_servicio int,
@tipo_servicio varchar(20),
@precio_servicio SMALLMONEY,
@id_plan varchar(20)
AS 
UPDATE servicios SET tipo_servicio=@tipo_servicio,
precio_servicio=@precio_servicio,
id_plan=@id_plan
WHERE id_plan=@id_plan;
GO

CREATE PROC eliminar_servicio
@id_servicio int
AS
DELETE FROM servicios WHERE id_servicio=@id_servicio;
go

CREATE PROC BuscarServicioPorTipoServicio
@tipo_servicio VARCHAR(20)
AS
SELECT * FROM servicios WHERE tipo_servicio=@tipo_servicio;
GO
/* ---------------------------------------------------- */
/* Cliente Servicio */
CREATE PROC mostrar_cliente_servicio
AS
SELECT * FROM cliente_servicio;
go

CREATE PROC insertar_cliente_servicio
@fecha_instalacion date,
@pago_instalacion SMALLMONEY,
@id_cliente VARCHAR(8),
@id_servicio int,
@cod_empleado int
AS
INSERT INTO cliente_servicio VALUES(@fecha_instalacion,@pago_instalacion,@id_cliente,@id_servicio,@cod_empleado);
GO

CREATE PROC actualizar_cliente_servicio
@id_cliente_servicio INT,
@fecha_instalacion date,
@pago_instalacion SMALLMONEY,
@id_cliente VARCHAR(8),
@id_servicio int,
@cod_empleado int
AS 
UPDATE cliente_servicio SET fecha_instalacion=@fecha_instalacion,
pago_instalacion=@pago_instalacion,
id_cliente=@id_cliente,
id_servicio=@id_servicio,
cod_empleado=@cod_empleado
WHERE id_cliente_servicio=@id_cliente_servicio;
GO

CREATE PROC eliminar_cliente_servicio
@id_cliente_servicio int
AS
DELETE FROM cliente_servicio WHERE id_cliente_servicio=@id_cliente_servicio;
go

CREATE PROC BuscarClienteServicioPorDni
@id_cliente VARCHAR(8)
AS
SELECT * FROM cliente_servicio WHERE id_cliente=@id_cliente;
GO

/* ----------------------------------- */
/* Pago Mensual */
CREATE PROC mostrar_pago_mensual
AS
SELECT * FROM pago_mensual;
go

CREATE PROC insertar_pago_mensual
@estado_pago VARCHAR(20),
@fecha_pago date,
@fecha_pagada date,
@pago_mensual SMALLMONEY,
@id_cliente_servicio int
AS
INSERT INTO pago_mensual VALUES(@estado_pago,@fecha_pago,@fecha_pagada,@pago_mensual,@id_cliente_servicio);
GO

CREATE PROC actualizar_pago_mensual
@id_pago_mensual int,
@estado_pago VARCHAR(20),
@fecha_pago date,
@fecha_pagada date,
@pago_mensual SMALLMONEY,
@id_cliente_servicio int
AS 
UPDATE pago_mensual SET estado_pago=@estado_pago,
fecha_pago=@fecha_pago,
fecha_pagada=@fecha_pagada,
pago_mensual=@pago_mensual,
id_cliente_servicio=@id_cliente_servicio
WHERE id_pago_mensual=@id_pago_mensual;
GO

CREATE PROC eliminar_pago_mensual
@id_pago_mensual int
AS
DELETE FROM pago_mensual WHERE id_pago_mensual=@id_pago_mensual;
go

CREATE PROC BuscarPagoMensualPorDni
@id_cliente VARCHAR(8)
AS
SELECT p.id_pago_mensual,p.estado_pago,p.fecha_pago,p.fecha_pagada,p.pago_mensual,cs.id_cliente
FROM pago_mensual AS p INNER JOIN cliente_servicio as cs ON p.id_cliente_servicio= cs.id_cliente_servicio
WHERE cs.id_cliente LIKE '%' +@id_cliente+'%';
GO

CREATE PROC BuscarPagoMensualPorNombreDni
@id_cliente VARCHAR(8)
AS
SELECT p.id_pago_mensual,p.estado_pago,p.fecha_pago,p.fecha_pagada,p.pago_mensual,cs.id_cliente
FROM pago_mensual AS p INNER JOIN cliente_servicio as cs ON p.id_cliente_servicio= cs.id_cliente_servicio
WHERE cs.id_cliente LIKE '%' +@id_cliente+'%';
GO
/* --------------------------------- */
/* Consultas Avanzadas */

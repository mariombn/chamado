CREATE TABLE usuarios (
    id INT(9) UNSIGNED NOT NULL AUTO_INCREMENT,
    login VARCHAR(20) NOT NULL,
    senha VARCHAR(250) NOT NULL,
    PRIMARY KEY (id),
    UNIQUE(login)
);

CREATE TABLE chamados (
    id INT(9) UNSIGNED NOT NULL AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    descricao TEXT NOT NULL,
    status ENUM ('aberto', 'atendimento', 'fechado') DEFAULT 'aberto',
    criacao_data DATE NOT NULL,
    criacao_hora TIME NOT NULL,
    criacao_user_id INT(9) UNSIGNED NOT NULL,
    user_id INT(9) UNSIGNED,
    PRIMARY KEY (id)
);

INSERT INTO usuarios VALUES (1, 'admin', 'admin');
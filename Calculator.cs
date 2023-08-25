package com.example.calculadora;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    EditText num1, num2, resultado;
    Button somar, subtrair, multiplicar, dividir, limpar, power, sqrt, cbrt;
    Double n1, n2, result;
    String message;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        num1 = (EditText) findViewById(R.id.editTextNum1);
        num2 = (EditText) findViewById(R.id.editTextNum2);
        resultado = (EditText) findViewById(R.id.editTextResultado);
        somar = (Button) findViewById(R.id.btnSoma);
        subtrair = (Button) findViewById(R.id.btnSubtracao);
        multiplicar = (Button) findViewById(R.id.btnMultiplicacao);
        dividir = (Button) findViewById(R.id.btnDivisao);
        limpar = (Button) findViewById(R.id.btnLimpar);
        power = (Button) findViewById(R.id.btnPower);
        sqrt = (Button) findViewById(R.id.btnSqrt);
        cbrt = (Button) findViewById(R.id.btnCbrt);
        somar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (TextUtils.isEmpty(num1.getText().toString()) || TextUtils.isEmpty(num2.getText().toString())) {
                    num1.setError("Digite o número");
                    num2.setError("Digite o número");
                } else {
                    n1 = Double.parseDouble(num1.getText().toString());
                    n2 = Double.parseDouble(num2.getText().toString());
                    result = n1 + n2;
                    message = result.toString();
                    resultado.setText(message);
                }
            }
        });
        subtrair.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (TextUtils.isEmpty(num1.getText().toString()) || TextUtils.isEmpty(num2.getText().toString())) {
                    num1.setError("Digite o número");
                    num2.setError("Digite o número");
                } else {
                    n1 = Double.parseDouble(num1.getText().toString());
                    n2 = Double.parseDouble(num2.getText().toString());
                    result = n1 - n2;
                    message = result.toString();
                    resultado.setText(message);
                }
            }
        });
        multiplicar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (TextUtils.isEmpty(num1.getText().toString()) || TextUtils.isEmpty(num2.getText().toString())) {
                    num1.setError("Digite o número");
                    num2.setError("Digite o número");
                } else {
                    n1 = Double.parseDouble(num1.getText().toString());
                    n2 = Double.parseDouble(num2.getText().toString());
                    result = n1 * n2;
                    message = result.toString();
                    resultado.setText(message);
                }
            }
        });
        dividir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (TextUtils.isEmpty(num1.getText().toString()) || TextUtils.isEmpty(num2.getText().toString())) {
                    num1.setError("Digite o número");
                    num2.setError("Digite o número");
                } else {
                    n1 = Double.parseDouble(num1.getText().toString());
                    n2 = Double.parseDouble(num2.getText().toString());
                    if (n2 == 0) {
                        Toast.makeText(MainActivity.this, "Divisão por zero é indeterminada!", Toast.LENGTH_SHORT).show();
                    } else {
                        result = n1 / n2;
                        message = result.toString();
                        resultado.setText(message);
                    }
                }
            }
        });
        limpar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num1.setText("");
                num2.setText("");
                resultado.setText("");
            }
        });
        power.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (TextUtils.isEmpty(num1.getText().toString()) || TextUtils.isEmpty(num2.getText().toString())) {
                    num1.setError("Digite o número");
                    num2.setError("Digite o número");
                } else {
                    n1 = Double.parseDouble(num1.getText().toString());
                    n2 = Double.parseDouble(num2.getText().toString());
                    result = Math.pow(n1, n2);
                    message = result.toString();
                    resultado.setText(message);
                }
            }
        });
        sqrt.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num2.setText("");
                if (TextUtils.isEmpty(num1.getText().toString())) {
                    num1.setError("Digite o número");
                }
                else
                {
                    n1 = Double.parseDouble(num1.getText().toString());
                    result = Math.sqrt(n1);
                    message = result.toString();
                    resultado.setText(message);
                }
            }
        });
        cbrt.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num2.setText("");
                if (TextUtils.isEmpty(num1.getText().toString())) {
                    num1.setError("Digite o número");
                }
                else
                {
                    n1 = Double.parseDouble(num1.getText().toString());
                    result = Math.cbrt(n1);
                    message = result.toString();
                    resultado.setText(message);
                }
            }
        });

    }
}

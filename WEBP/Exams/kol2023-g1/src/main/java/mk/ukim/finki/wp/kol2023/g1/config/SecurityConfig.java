package mk.ukim.finki.wp.kol2023.g1.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityCustomizer;
import org.springframework.security.config.annotation.web.configurers.AbstractHttpConfigurer;


import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.SecurityFilterChain;
import org.springframework.security.web.util.matcher.AntPathRequestMatcher;

/**
 *  This class is used to configure user login on path '/login' and logout on path '/logout'.
 *  The only public page in the application should be '/'.
 *  All other pages should be visible only for a user with role 'ROLE_ADMIN'.
 *  Furthermore, in the "list.html" template, the 'Edit', 'Delete', 'Add' buttons should only be
 *  visible for a user with role 'ROLE_ADMIN'.
 *  The 'Vote for Player' button should only be visible for a user with role 'ROLE_USER'.
 *
 *  For login inMemory users should be used. Their credentials are given below:
 *  [{
 *      username: "user",
 *      password: "user",
 *      role: "ROLE_USER"
 *  },
 *
 *  {
 *      username: "admin",
 *      password: "admin",
 *      role: "ROLE_ADMIN"
 *  }]
 */
@Configuration
@EnableWebSecurity
public class SecurityConfig {
    private final PasswordEncoder passwordEncoder;

    public SecurityConfig(PasswordEncoder passwordEncoder) {
        this.passwordEncoder = passwordEncoder;
    }

//    @Bean
    // TODO: If you are implementing the security requirements, remove this following bean creation
//    public WebSecurityCustomizer webSecurityCustomizer() {
//        return (web) -> web.ignoring().anyRequest();
//    }
    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception  {

        http
                .csrf(AbstractHttpConfigurer::disable)
                .authorizeHttpRequests( (requests) -> requests
                        .requestMatchers(AntPathRequestMatcher.antMatcher("/"),AntPathRequestMatcher.antMatcher("/players"))
                        .permitAll()
                        .requestMatchers(AntPathRequestMatcher.antMatcher("/players/*/vote")).hasRole("USER")
                        .anyRequest().hasRole("ADMIN")
                )
                .formLogin((form) -> form
                        .permitAll()
                        .failureUrl("/login?error=BadCredentials")
                        .defaultSuccessUrl("/players", true)
                )
                .logout((logout) -> logout
                        .logoutUrl("/logout")
                        .clearAuthentication(true)
                        .invalidateHttpSession(true)
                        .deleteCookies("JSESSIONID")
                        .logoutSuccessUrl("/")
                )
                .exceptionHandling((ex) -> ex
                        .accessDeniedPage("/access_denied")
                );

        return http.build();
    }


    @Bean
    public AuthenticationManager authManager(HttpSecurity http) throws Exception {
        AuthenticationManagerBuilder authenticationManagerBuilder =
                http.getSharedObject(AuthenticationManagerBuilder.class);
        authenticationManagerBuilder.inMemoryAuthentication()
                .withUser("user").password(passwordEncoder.encode("user")).roles("USER")
                .and().withUser("admin").password(passwordEncoder.encode("admin")).roles("ADMIN");
        return authenticationManagerBuilder.build();
    }

}

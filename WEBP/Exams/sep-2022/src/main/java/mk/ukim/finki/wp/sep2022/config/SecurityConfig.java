package mk.ukim.finki.wp.sep2022.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.builders.WebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityCustomizer;
import org.springframework.security.config.annotation.web.configurers.AbstractHttpConfigurer;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.SecurityFilterChain;
import org.springframework.security.web.util.matcher.AntPathRequestMatcher;

/**
 *  This class is used to configure user login on path '/login' and logout on path '/logout'.
 *  The only public page in the application should be '/'.
 *  All other pages should be visible only for a user with role 'ROLE_ADMIN'.
 *  Furthermore, in the "list.html" template, the 'Edit', 'Delete', 'Add' buttons should only be
 *  visible for a user with role 'ROLE_ADMIN'.
 *  The 'Follow Match' button should only be visible for a user with role 'ROLE_USER'.
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
public class SecurityConfig {

//    @Bean
//    // TODO: If you are implementing the security requirements, remove this following bean creation
//    public WebSecurityCustomizer webSecurityCustomizer() {
//        return (web) -> web.ignoring().anyRequest();
//    }

    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception  {

        http
                .csrf(AbstractHttpConfigurer::disable)
                .authorizeHttpRequests( (requests) -> requests
                        .requestMatchers(AntPathRequestMatcher.antMatcher("/"),AntPathRequestMatcher.antMatcher("/matches"))
                        .permitAll()
                        .anyRequest()
                        .authenticated()
                )
                .formLogin((form) -> form
                        .permitAll()
                        .failureUrl("/login?error=BadCredentials")
                        .defaultSuccessUrl("/matches", true)
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
    PasswordEncoder passwordEncoder(){
        return new BCryptPasswordEncoder(10);
    }

    @Bean
    public AuthenticationManager authManager(HttpSecurity http) throws Exception {
        AuthenticationManagerBuilder authenticationManagerBuilder =
                http.getSharedObject(AuthenticationManagerBuilder.class);
        authenticationManagerBuilder.inMemoryAuthentication()
                .withUser("admin").password(passwordEncoder().encode("admin")).roles("ADMIN")
                .and()
                .withUser("user").password(passwordEncoder().encode("user")).roles("USER");
        return authenticationManagerBuilder.build();
    }

}

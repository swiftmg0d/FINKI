package mk.ukim.finki.wp.kol2022.g3.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configurers.AbstractHttpConfigurer;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.web.SecurityFilterChain;
import org.springframework.security.web.util.matcher.AntPathRequestMatcher;

/**
 * This class is used to configure user login on path '/login' and logout on path '/logout'.
 * The only public page in the application should be '/'.
 * All other pages should be visible only for a user with role 'ROLE_ADMIN'.
 * Furthermore, in the "list.html" template, the 'Edit', 'Delete', 'Add' buttons should only be
 * visible for a user with role 'ROLE_ADMIN'.
 * <p>
 * For login the forum users from the database should be used, where username should be the email.
 */
@EnableWebSecurity
@Configuration
public class SecurityConfig {
//    @Bean
//    // TODO: If you are implementing the security requirements, remove this following bean creation
//    public WebSecurityCustomizer webSecurityCustomizer() {
//        return (web) -> web.ignoring().anyRequest();
//    }
    private final UserDetailsService userDetailsService;

    public SecurityConfig(UserDetailsService userDetailsService) {
        this.userDetailsService = userDetailsService;
    }

    @Bean
public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception  {

    http
            .csrf(AbstractHttpConfigurer::disable)
            .authorizeHttpRequests( (requests) -> requests
                    .requestMatchers(AntPathRequestMatcher.antMatcher("/"))
                    .permitAll()
                    .anyRequest()
                    .authenticated()
            )
            .formLogin((form) -> form
                    .permitAll()
                    .failureUrl("/login?error=BadCredentials")
                    .defaultSuccessUrl("/users", true)
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
        authenticationManagerBuilder.userDetailsService(userDetailsService);
        return authenticationManagerBuilder.build();
    }

}
